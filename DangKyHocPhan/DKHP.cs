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
        private string MSSV = TrangchuSV.MSSV.ToString();
        public DKHP()
        {
            InitializeComponent();
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

            // Hiển thi thông tin SV
            txtMSSV.Text = MSSV;
        }

        private void LoadDSMonHocMo()
        {
            string query = "SELECT MaMon, TenMon, LoaiMon, SoTiet FROM dbo.MONHOCMO JOIN dbo.MONHOC ON dbo.MONHOC.MaMon = dbo.MONHOCMO.MonHoc WHERE MaHK = @MaHK AND MONHOCMO.MonHoc NOT IN (SELECT MonHoc FROM dbo.DKHocPhan WHERE SoPhieu = @SoPhieu)";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHK", cboHocKy.SelectedValue.ToString());
                command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
                DataTable dataTable = new DataTable();
                connection.Open();
                dataTable.Load(command.ExecuteReader());
                connection.Close();
                dgvDSMonHocMo.DataSource = dataTable;
            }
        }

        private void LoadDSMonDangKy()
        {
            string query = "SELECT MaMon, TenMon, LoaiMon, SoTiet FROM dbo.DKHocPhan JOIN dbo.MONHOC ON dbo.MONHOC.MaMon = dbo.DKHocPhan.MonHoc WHERE SoPhieu = @SoPhieu";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaHK", cboHocKy.SelectedValue.ToString());
                command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
                DataTable dataTable = new DataTable();
                dataTable = new DataTable();
                connection.Open();
                dataTable.Load(command.ExecuteReader());
                connection.Close();
                dgvDSMonDK.DataSource = dataTable;
            }
        }

        private void cboHocKy_DropDownClosed(object sender, EventArgs e)
        {
            // Kiểm tra SV đã có phiếu DK của học kỳ này chưa
            string query = "SELECT * FROM dbo.PHIEUDK WHERE MaSV = @MSSV AND MaHK = @HocKy";
            bool coPhieu = false;
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@MSSV", MSSV);
                    adapter.SelectCommand.Parameters.AddWithValue("@HocKy", cboHocKy.SelectedValue.ToString());

                    DataTable result = new DataTable();
                    adapter.Fill(result);
                    coPhieu = result != null && result.Rows.Count == 1;
                    txtNgayLap.Text = coPhieu ? result.Rows[0]["NgayLap"].ToString() : DateTime.Now.ToString();

                }
            }

            _SoPhieu = MSSV + cboHocKy.SelectedValue.ToString();

            if (!coPhieu)
            {
                query = "INSERT INTO dbo.PHIEUDK VALUES (@SoPhieu, @MaSV, @MaHK, GETDATE())";
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
                    command.Parameters.AddWithValue("@MaSV", MSSV);
                    command.Parameters.AddWithValue("@MaHK", cboHocKy.SelectedValue.ToString());
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Hiển thị thông tin phiếu DK
            txtSoPhieu.Text = _SoPhieu;
            LoadDSMonHocMo();
            LoadDSMonDangKy();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO dbo.DKHOCPHAN VALUES (@SoPhieu, @MonHoc)";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
                command.Parameters.AddWithValue("@MonHoc", dgvDSMonHocMo.Rows[dgvDSMonHocMo.CurrentCell.RowIndex].Cells[0].Value.ToString());
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            LoadDSMonHocMo();
            LoadDSMonDangKy();
        }

        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM dbo.DKHOCPHAN WHERE SoPhieu = @SoPhieu AND MonHoc = @MonHoc";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SoPhieu", _SoPhieu);
                command.Parameters.AddWithValue("@MonHoc", dgvDSMonDK.Rows[dgvDSMonDK.CurrentCell.RowIndex].Cells[0].Value.ToString());
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            LoadDSMonHocMo();
            LoadDSMonDangKy();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangchuSV form = new TrangchuSV();
            form.ShowDialog();
        }

        private void btnThuPhi_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhieuThuHocPhi form = new PhieuThuHocPhi();
            form.ShowDialog();
        }

        private void dgvDSMonDK_DataSourceChanged(object sender, EventArgs e)
        {
            // Cập nhập số tín chỉ đăng ký
        }
    }
}
