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

        private void Khoa_Load(object sender, EventArgs e)
        {
            LoadDSKhoa();
        }

        private void dgvDSKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDSKhoa.Rows[e.RowIndex];
            txtMaKhoa.Text = row.Cells[0].Value.ToString();
            txtTenKhoa.Text = row.Cells[1].Value.ToString();
        }

        private void btnThemKhoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhoa.Text == "")
            {
                MessageBox.Show("Mã khoa không được để trống!");
            }
            else {
                string query = "SELECT * FROM dbo.KHOA WHERE MaKhoa = @MaKhoa";
                bool trungKhoa = false;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                    connection.Open();
                    SqlDataReader Exist = command.ExecuteReader();
                    trungKhoa = Exist.HasRows;
                    connection.Close();
                }

                if (trungKhoa)
                {
                    MessageBox.Show("Bị trùng mã khoa! Vui lòng nhập lại!");
                }
                else
                {
                    query = "INSERT INTO dbo.KHOA VALUES (@MaKhoa, @TenKhoa)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaKhoa", txtMaKhoa.Text);
                        command.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    LoadDSKhoa();
                }
            }
        }

        private void btnSuaKhoa_Click(object sender, EventArgs e)
        {
            // Add
            string query = "UPDATE dbo.KHOA SET TenKhoa = @TenKhoa WHERE MaKhoa = @MaKhoa";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKhoa", dgvDSKhoa.Rows[dgvDSKhoa.SelectedRows[0].Index].Cells[0].Value.ToString());
                command.Parameters.AddWithValue("@TenKhoa", txtTenKhoa.Text);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            LoadDSKhoa();
        }

        private void btnXoaKhoa_Click(object sender, EventArgs e)
        {
            // Add
            string query = "DELETE FROM dbo.KHOA WHERE MaKhoa = @MaKhoa";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@MaKhoa", dgvDSKhoa.Rows[dgvDSKhoa.SelectedRows[0].Index].Cells[0].Value.ToString());
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            LoadDSKhoa();
        }
    }
}
