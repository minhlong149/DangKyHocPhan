using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace DangKyHocPhan
{
    public partial class DKHP : Form
    {
        private string _SoPhieu;
        public DKHP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DKHP_Load(object sender, EventArgs e)
        {
            // Load cboHocKy
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                string query = "SELECT * FROM dbo.DSHOCKY ORDER BY NamHoc DESC, HocKy DESC";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    data.Columns.Add("HienThi", typeof(String));

                    foreach (DataRow row in data.Rows)
                    {
                        row["HienThi"] = ("Học kỳ " + (row["HocKy"].ToString() == "0" ? "hè" : row["HocKy"].ToString()) + " - Năm học " + row["NamHoc"].ToString());
                    }
                    

                    cboHocKy.DataSource = data;
                    cboHocKy.ValueMember = "MaHK";
                    cboHocKy.DisplayMember = "HienThi";
                }
            }
        }

        private void cboHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboHocKy_DropDownClosed(object sender, EventArgs e)
        {
            // Kiểm tra SV đã có phiếu DK của học kỳ này chưa
            string query = "SELECT * FROM dbo.PHIEUDK WHERE MaSV = @MSSV AND MaHK = @HocKy";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MSSV", TrangchuSV.MSSV.ToString());
            command.Parameters.AddWithValue("@HocKy", cboHocKy.SelectedValue.ToString());
            SqlDataReader Exist = command.ExecuteReader();
            bool coPhieu = Exist.HasRows;
            connection.Close();

            _SoPhieu = TrangchuSV.MSSV.ToString() + cboHocKy.SelectedValue.ToString();

            if (!coPhieu)
            {
                // Tạo phiếu đăng ký nếu chưa có
                query = "INSERT INTO dbo.PHIEUDK VALUES (@SoPhieu, @MaSV, @MaHK, GETDATE())";
                command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
                command.Parameters.AddWithValue("@MaSV", TrangchuSV.MSSV.ToString());
                command.Parameters.AddWithValue("@MaHK", cboHocKy.SelectedValue.ToString());
                command.ExecuteNonQuery();
                connection.Close();
            }

            // Hiện thị danh sách môn học mở trong kỳ
            query = "SELECT MaMon, TenMon, LoaiMon, SoTiet FROM dbo.MONHOCMO JOIN dbo.MONHOC ON dbo.MONHOC.MaMon = dbo.MONHOCMO.MonHoc WHERE MaHK = @MaHK AND MONHOCMO.MonHoc NOT IN (SELECT MonHoc FROM dbo.DKHocPhan WHERE SoPhieu = @SoPhieu)";
            command = new SqlCommand(query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@MaHK", cboHocKy.SelectedValue.ToString());
            command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            dgvDSMonHocMo.DataSource = dataTable;
            connection.Close();
            
            // Hiện thị danh sách môn học đã đăng ký
            query = "SELECT MaMon, TenMon, LoaiMon, SoTiet FROM dbo.DKHocPhan JOIN dbo.MONHOC ON dbo.MONHOC.MaMon = dbo.DKHocPhan.MonHoc WHERE SoPhieu = @SoPhieu";
            command = new SqlCommand(query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@MaHK", cboHocKy.SelectedValue.ToString());
            command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
            dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            connection.Close();
            dgvDSMonDK.DataSource = dataTable;
            connection.Close();
            
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO dbo.DKHOCPHAN VALUES (@SoPhieu, @MonHoc)";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
            command.Parameters.AddWithValue("@MonHoc", dgvDSMonHocMo.Rows[dgvDSMonHocMo.CurrentCell.RowIndex].Cells[0].Value.ToString());
            command.ExecuteNonQuery();
            connection.Close();

            // Hiện thị danh sách môn học mở trong kỳ
            query = "SELECT MaMon, TenMon, LoaiMon, SoTiet FROM dbo.MONHOCMO JOIN dbo.MONHOC ON dbo.MONHOC.MaMon = dbo.MONHOCMO.MonHoc WHERE MaHK = @MaHK AND MONHOCMO.MonHoc NOT IN (SELECT MonHoc FROM dbo.DKHocPhan WHERE SoPhieu = @SoPhieu)";
            command = new SqlCommand(query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@MaHK", cboHocKy.SelectedValue.ToString());
            command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            dgvDSMonHocMo.DataSource = dataTable;
            connection.Close();

            // Hiện thị danh sách môn học đã đăng ký
            query = "SELECT MaMon, TenMon, LoaiMon, SoTiet FROM dbo.DKHocPhan JOIN dbo.MONHOC ON dbo.MONHOC.MaMon = dbo.DKHocPhan.MonHoc WHERE SoPhieu = @SoPhieu";
            command = new SqlCommand(query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@MaHK", cboHocKy.SelectedValue.ToString());
            command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
            dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            connection.Close();
            dgvDSMonDK.DataSource = dataTable;
            connection.Close();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM dbo.DKHOCPHAN WHERE SoPhieu = @SoPhieu AND MonHoc = @MonHoc";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
            command.Parameters.AddWithValue("@MonHoc", dgvDSMonDK.Rows[dgvDSMonDK.CurrentCell.RowIndex].Cells[0].Value.ToString());
            command.ExecuteNonQuery();
            connection.Close();

            // Hiện thị danh sách môn học mở trong kỳ
            query = "SELECT MaMon, TenMon, LoaiMon, SoTiet FROM dbo.MONHOCMO JOIN dbo.MONHOC ON dbo.MONHOC.MaMon = dbo.MONHOCMO.MonHoc WHERE MaHK = @MaHK AND MONHOCMO.MonHoc NOT IN (SELECT MonHoc FROM dbo.DKHocPhan WHERE SoPhieu = @SoPhieu)";
            command = new SqlCommand(query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@MaHK", cboHocKy.SelectedValue.ToString());
            command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            dgvDSMonHocMo.DataSource = dataTable;
            connection.Close();

            // Hiện thị danh sách môn học đã đăng ký
            query = "SELECT MaMon, TenMon, LoaiMon, SoTiet FROM dbo.DKHocPhan JOIN dbo.MONHOC ON dbo.MONHOC.MaMon = dbo.DKHocPhan.MonHoc WHERE SoPhieu = @SoPhieu";
            command = new SqlCommand(query, connection);
            connection.Open();
            command.Parameters.AddWithValue("@MaHK", cboHocKy.SelectedValue.ToString());
            command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
            dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            connection.Close();
            dgvDSMonDK.DataSource = dataTable;
            connection.Close();
        }
    }
}
