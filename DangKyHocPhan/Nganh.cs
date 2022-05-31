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

namespace DangKyHocPhan
{
    public partial class Nganh : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);

        public Nganh()
        {
            InitializeComponent();
        }

        void LoadDSNganh()
        {
            string query = "SELECT * FROM dbo.NGANH WHERE ThuocKhoa = @Khoa";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Khoa", cboThuocKhoa.SelectedValue.ToString());
                DataTable dataTable = new DataTable();
                connection.Open();
                dataTable.Load(command.ExecuteReader());
                connection.Close();
                dgvDSNganh.DataSource = dataTable;
            }
        }

        void LoadThongTin()
        {
            DataGridViewRow row = dgvDSNganh.CurrentRow;
            if (row != null)
            {
                txtMaNganh.Text = row.Cells[0].Value.ToString();
                txtTenNganh.Text = row.Cells[1].Value.ToString();
            }
        }

        private void Nganh_Load(object sender, EventArgs e)
        {
            // Combo box
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                string query = "SELECT * FROM dbo.KHOA";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    //Fill the DataTable with records from Table.
                    DataTable data = new DataTable();
                    adapter.Fill(data);

                    //Assign DataTable as DataSource.
                    cboThuocKhoa.DataSource = data;
                    cboThuocKhoa.DisplayMember = "TenKhoa";
                    cboThuocKhoa.ValueMember = "MaKhoa";
                }
            }
            LoadDSNganh();
            LoadThongTin();
        }

        private void dgvDSNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDSNganh.CurrentRow;
            txtMaNganh.Text = row.Cells[0].Value.ToString();
            txtTenNganh.Text = row.Cells[1].Value.ToString();
        }

        private void cboThuocKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDSNganh();
            LoadThongTin();
        }

        bool trungNganh(string MaNganh)
        {
            string query = "SELECT * FROM dbo.NGANH WHERE MaNganh = @MaNganh";
            bool trungNganh = false;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaNganh", MaNganh);
                connection.Open();
                SqlDataReader Exist = command.ExecuteReader();
                trungNganh = Exist.HasRows;
                connection.Close();
            }
            return trungNganh;
        }

        private void btnThemNganh_Click(object sender, EventArgs e)
        {
            if (txtMaNganh.Text == "")
            {
                MessageBox.Show("Mã ngành không được để trống!", "Thêm ngành");
            }
            else if (trungNganh(txtMaNganh.Text))
            {
                MessageBox.Show("Ngành " + txtMaNganh.Text + " đã bị trùng! Vui lòng nhập lại!", "Thêm ngành");
            }
            else
            {
                string query = "INSERT INTO dbo.NGANH VALUES (@MaNganh, @TenNganh, @ThuocKhoa)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNganh", txtMaNganh.Text);
                    command.Parameters.AddWithValue("@TenNganh", txtTenNganh.Text);
                    command.Parameters.AddWithValue("@ThuocKhoa", cboThuocKhoa.SelectedValue.ToString());
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadDSNganh();
                LoadThongTin();
            }
            
        }

        bool coThamChieuNganh(string NganhHoc) 
        {
            string querySV = "SELECT * FROM SINHVIEN WHERE NganhHoc = @NganhHoc";
            bool khongTrung = true;
            using (SqlCommand command = new SqlCommand(querySV, connection))
            {
                command.Parameters.AddWithValue("@NganhHoc", NganhHoc);
                connection.Open();
                SqlDataReader Exist = command.ExecuteReader();
                khongTrung = khongTrung && !Exist.HasRows;
                connection.Close();
            }
            Console.WriteLine("SV: "+ khongTrung);
            string queryCT = "SELECT * FROM CHUONGTRINH WHERE NganhHoc = @NganhHoc";
            using (SqlCommand command = new SqlCommand(queryCT, connection))
            {
                command.Parameters.AddWithValue("@NganhHoc", NganhHoc);
                connection.Open();
                SqlDataReader Exist = command.ExecuteReader();
                khongTrung = khongTrung && !Exist.HasRows;
                connection.Close();
            }
            Console.WriteLine("CT: " + khongTrung);
            return !khongTrung;
        }

        private void btnSuaNganh_Click(object sender, EventArgs e)
        {
            string maNganh_dgv = dgvDSNganh.CurrentRow.Cells[0].Value.ToString();
            string maNganh_txt = txtMaNganh.Text;
            if (coThamChieuNganh(maNganh_dgv))
            {
                MessageBox.Show("Không thể thay đổi ngành " + maNganh_dgv + " vì có dữ liệu tham chiếu đến!", "Sửa ngành");
            }
            else if (txtMaNganh.Text == "")
            {
                MessageBox.Show("Mã ngành không được để trống!", "Sửa ngành");
            }
            else if (trungNganh(maNganh_txt)) {
                MessageBox.Show("Ngành " + maNganh_txt + " đã tồn tại! Vui lòng nhập lại!", "Sửa ngành");
                DataGridViewRow row = dgvDSNganh.CurrentRow;
                txtMaNganh.Text = row.Cells[0].Value.ToString();
                txtTenNganh.Text = row.Cells[1].Value.ToString();
            }
            else
            {
                string query = "UPDATE dbo.NGANH SET MaNganh = @MaNganhMoi, TenNganh = @TenNganh, ThuocKhoa = @ThuocKhoa WHERE MaNganh = @MaNganhCu";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNganhCu", maNganh_dgv);
                    command.Parameters.AddWithValue("@MaNganhMoi", maNganh_txt);
                    command.Parameters.AddWithValue("@TenNganh", txtTenNganh.Text);
                    command.Parameters.AddWithValue("@ThuocKhoa", cboThuocKhoa.SelectedValue.ToString());
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadDSNganh();
                LoadThongTin();
            }
            
        }

        private void btnXoaNganh_Click(object sender, EventArgs e)
        {
            string maNganh = dgvDSNganh.CurrentRow.Cells[0].Value.ToString();
            Console.WriteLine(maNganh + " - " + coThamChieuNganh(maNganh));
            if (!coThamChieuNganh(maNganh))
            {
                string message = "Bạn có muốn xóa ngành " + maNganh + " không?";
                DialogResult result = MessageBox.Show(message, "Xóa ngành", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM dbo.NGANH WHERE MaNganh = @MaNganh";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaNganh", dgvDSNganh.Rows[dgvDSNganh.CurrentCell.RowIndex].Cells[0].Value.ToString());
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    LoadDSNganh();
                    LoadThongTin();
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa ngành " + maNganh + " vì có dữ liệu tham chiếu đến!", "Xóa ngành");
            }
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Khoa form = new Khoa();
            form.ShowDialog();
        }
    }
}
