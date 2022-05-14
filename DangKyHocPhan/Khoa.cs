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
        public Khoa()
        {
            InitializeComponent();
        }

        private void Khoa_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dbo.KHOA";

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\DKHP.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);           
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            DataTable dataTable = new DataTable();
            dataTable.Load(command.ExecuteReader());
            connection.Close();

            dgvDSKhoa.DataSource = dataTable;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhoa_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDSKhoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDSKhoa.Rows[e.RowIndex];
            txtMaKhoa.Text = row.Cells[0].Value.ToString();
            txtTenKhoa.Text = row.Cells[1].Value.ToString();
        }

        private void dgvDSKhoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
