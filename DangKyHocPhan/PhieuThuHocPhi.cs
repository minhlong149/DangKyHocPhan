using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhan
{
    public partial class PhieuThuHocPhi : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
        public PhieuThuHocPhi()
        {
            InitializeComponent();
        }

        private void PhieuThuHocPhi_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_them_Click(object sender, EventArgs e)
        {
            //Kiem tra
            if (String.IsNullOrEmpty(text_mssv.Text))
            {
                MessageBox.Show("Bạn chưa điền mã số sinh viên!");
                return;
            }
            if (String.IsNullOrEmpty(text_so_tien_thu.Text))
            {
                MessageBox.Show("Bạn chưa điền số tiền thu!");
                return;
            }

            //Ghi vao csdl
            string queryString = "INSERT INTO dbo.THUHOCPHI VALUES (@MaSV, @SoPhieu ,@SoTienThu, @NgayThu)";
            StringBuilder errorMessages = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    command.Parameters.AddWithValue("@MaSV", text_mssv.Text);
                    command.Parameters.AddWithValue("@SoPhieu", "000112022");
                    command.Parameters.AddWithValue("@SoTienThu", text_so_tien_thu.Text);
                    command.Parameters.AddWithValue("@NgayThu", date_picker_ngay_lap.Value);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex)
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(),"Lỗi");
                }
            }
            Console.WriteLine("Hello");
            return;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void date_picker_ngay_lap_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
