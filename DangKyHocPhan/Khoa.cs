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
    public partial class Khoa : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);

        public Khoa()
        {
            InitializeComponent();
        }

        void LoadDSKhoa()
        {
            string query = "SELECT * FROM dbo.KHOA";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();
                connection.Open();
                dataTable.Load(command.ExecuteReader());
                connection.Close();
                dgvDSKhoa.DataSource = dataTable;
            }
        }

        void LoadThongTin()
        {
            DataGridViewRow row = dgvDSKhoa.Rows[dgvDSKhoa.CurrentCell.RowIndex];
            txtMaKhoa.Text = row.Cells[0].Value.ToString();
            txtTenKhoa.Text = row.Cells[1].Value.ToString();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            LoadDSKhoa();
            LoadThongTin();
        }

        private void dgvDSKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadThongTin();
        }

        bool trungKhoa(string maKhoa)
        {
            string query = "SELECT * FROM dbo.KHOA WHERE MaKhoa = @MaKhoa";
            bool trungKhoa = false;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKhoa", maKhoa);
                connection.Open();
                SqlDataReader Exist = command.ExecuteReader();
                trungKhoa = Exist.HasRows;
                connection.Close();
            }
            return trungKhoa;
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Mã khoa không được để trống!", "Thêm khoa");
            }
            else if (trungKhoa(txtMaKhoa.Text))
            {
                MessageBox.Show("Khoa " + txtMaKhoa.Text + " đã bị trùng! Vui lòng nhập lại!", "Thêm khoa");
            }
            else
            {
                string query = "INSERT INTO dbo.KHOA VALUES (@MaKhoa, @TenKhoa)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                    command.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadDSKhoa();
                LoadThongTin();
            }
        }
        bool coThamChieuKhoa(string maKhoa)
        {
            string query = "SELECT * FROM dbo.CHUONGTRINH WHERE Khoa = @Khoa";
            bool khongTrung = true;
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@Khoa", maKhoa);
                connection.Open();
                SqlDataReader Exist = command.ExecuteReader();
                khongTrung = khongTrung && !Exist.HasRows;
                connection.Close();
            }
            string queryNganh = "SELECT * FROM dbo.NGANH WHERE ThuocKhoa = @Khoa";
            using (SqlCommand command = new SqlCommand(queryNganh, connection))
            {
                command.Parameters.AddWithValue("@Khoa", maKhoa);
                connection.Open();
                SqlDataReader Exist = command.ExecuteReader();
                khongTrung = khongTrung && !Exist.HasRows;
                connection.Close();
            }
            return khongTrung;
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            string maKhoa_dgv = dgvDSKhoa.Rows[dgvDSKhoa.SelectedRows[0].Index].Cells[0].Value.ToString();
            string maKhoa_txt = txtMaKhoa.Text;
            if (coThamChieuKhoa(maKhoa_dgv))
            {
                MessageBox.Show("Không thể thay đổi khoa " + maKhoa_dgv + " vì có dữ liệu tham chiếu đến!", "Sửa khoa");
            }
            else if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Mã khoa không được để trống!", "Sửa khoa");
            }
            else if (trungKhoa(maKhoa_txt))
            {
                MessageBox.Show("Khoa " + maKhoa_txt + " đã tồn tại! Vui lòng nhập lại!", "Sửa khoa");
                LoadThongTin();
            }
            else
            {
                string query = "UPDATE dbo.KHOA SET MaKhoa = @MaKhoaMoi, TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoaCu";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKhoaCu", maKhoa_dgv);
                    command.Parameters.AddWithValue("@MaKhoaMoi", maKhoa_txt);
                    command.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                LoadDSKhoa();
                LoadThongTin();
            }

        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            string maKhoa = dgvDSKhoa.Rows[dgvDSKhoa.SelectedRows[0].Index].Cells[0].Value.ToString();
            if (!coThamChieuKhoa(maKhoa))
            {
                string message = "Bạn có muốn xóa khoa " + maKhoa + " không?";
                DialogResult result = MessageBox.Show(message, "Xóa khoa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string query = "DELETE FROM dbo.KHOA WHERE MaKhoa = @MaKhoa";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaKhoa", maKhoa);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    LoadDSKhoa();
                    LoadThongTin();
                }
            }
            else
            {
                MessageBox.Show("Không thể xóa khoa " + maKhoa + " vì có dữ liệu tham chiếu đến!", "Xóa khoa");
            }
        }

        private void ngànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nganh form = new Nganh();
            form.ShowDialog();
        }
    }
}
