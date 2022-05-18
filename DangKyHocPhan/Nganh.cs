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
        public Nganh()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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


            // Datagrid
            string query2 = "SELECT * FROM dbo.NGANH WHERE ThuocKhoa = @Khoa";
            SqlConnection connection2 = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
            connection2.Open();
            SqlCommand command = new SqlCommand(query2, connection2);
            command.Parameters.AddWithValue("@Khoa", cboThuocKhoa.SelectedValue.ToString());
            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            connection2.Close();

            dgvDSNganh.DataSource = dataTable;

            DataGridViewRow row = dgvDSNganh.CurrentRow;
            txtMaNganh.Text = row.Cells[0].Value.ToString();
            txtTenNganh.Text = row.Cells[1].Value.ToString();
        }

        private void dgvDSNganh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDSNganh.Rows[e.RowIndex];
            txtMaNganh.Text = row.Cells[0].Value.ToString();
            txtTenNganh.Text = row.Cells[1].Value.ToString();
        }

        private void cboThuocKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query2 = "SELECT * FROM dbo.NGANH WHERE ThuocKhoa = @Khoa";
            SqlConnection connection2 = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
            connection2.Open();
            SqlCommand command = new SqlCommand(query2, connection2);
            command.Parameters.AddWithValue("@Khoa", cboThuocKhoa.SelectedValue.ToString());
            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            connection2.Close();
            dgvDSNganh.DataSource = dataTable;
        }
    }
}
