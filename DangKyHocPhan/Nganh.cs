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
            DataGridViewRow row = dgvDSNganh.CurrentRow;
            txtMaNganh.Text = row.Cells[0].Value.ToString();
            txtTenNganh.Text = row.Cells[1].Value.ToString();
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
        }

        private void btnThemNganh_Click(object sender, EventArgs e)
        {

            if (txtMaNganh.Text == "")
            {
                MessageBox.Show("Mã ngành không được để trống!", "Thêm ngành");
            }
            else
            {
                string query = "SELECT * FROM dbo.NGANH WHERE MaNganh = @MaNganh";
                bool trungNganh = false;
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaNganh", txtMaNganh.Text);
                    connection.Open();
                    SqlDataReader Exist = command.ExecuteReader();
                    trungNganh = Exist.HasRows;
                    connection.Close();
                }
                if (trungNganh)
                {
                    MessageBox.Show("Bị trùng mã ngành! Vui lòng nhập lại!", "Thêm ngành");
                }
                else
                {
                    query = "INSERT INTO dbo.NGANH VALUES (@MaNganh, @TenNganh, @ThuocKhoa)";
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
                    DataGridViewRow row = dgvDSNganh.CurrentRow;
                    txtMaNganh.Text = row.Cells[0].Value.ToString();
                    txtTenNganh.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        private void btnSuaNganh_Click(object sender, EventArgs e)
        {
            string maNganh_dgv = dgvDSNganh.CurrentRow.Cells[0].Value.ToString();
            string maNganh_txt = txtMaNganh.Text;
            if (maNganh_dgv != maNganh_txt)
            {
                MessageBox.Show("Bạn không thể sửa mã ngành. Vui lòng thử lại!", "Sửa ngành");
                DataGridViewRow row = dgvDSNganh.CurrentRow;
                txtMaNganh.Text = row.Cells[0].Value.ToString();
                txtTenNganh.Text = row.Cells[1].Value.ToString();
            }
            else
            {
                if (txtMaNganh.Text == "")
                {
                    MessageBox.Show("Mã ngành không được để trống!", "Sửa ngành");
                }
                else
                {
                    string query = "UPDATE dbo.NGANH SET TenNganh = @TenNganh, ThuocKhoa = @ThuocKhoa WHERE MaNganh = @MaNganh";
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
                    DataGridViewRow row = dgvDSNganh.CurrentRow;
                    txtMaNganh.Text = row.Cells[0].Value.ToString();
                    txtTenNganh.Text = row.Cells[1].Value.ToString();
                }
            }
        }

        private void btnXoaNganh_Click(object sender, EventArgs e)
        {
            string maNganh = dgvDSNganh.CurrentRow.Cells[0].Value.ToString();
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
                DataGridViewRow row = dgvDSNganh.CurrentRow;
                txtMaNganh.Text = row.Cells[0].Value.ToString();
                txtTenNganh.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            TrangchuPDT form = new TrangchuPDT();
            form.ShowDialog();
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            Khoa form = new Khoa();
            form.ShowDialog();
        }
    }
}
