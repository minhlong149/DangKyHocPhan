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
using System.Numerics;

namespace DangKyHocPhan
{ 
    public partial class DongTien : Form
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
        public DongTien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_chuyenTien_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBox_soTien.Text))
                return;

            if (decimal.Parse(txtBox_soTien.Text) > PhieuThuHocPhi.SoTienThu)
            {
                MessageBox.Show("Số tiền thu phải nhỏ hơn hoặc bằng số tiền cần đóng", "Lỗi");
                return;
            }
            string money = txtBox_soTien.Text;
            string message = "Bạn sẽ chuyển đi số tiền " + money + " VNĐ ?";
            DialogResult dialogResult = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string queryString = "INSERT INTO THUHOCPHI VALUES (@MaSV,@SoPhieu,@SoTienThu,@NgayThu);";
                StringBuilder errorMessages = new StringBuilder();

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    try
                    {
                        command.Parameters.AddWithValue("@MaSV", PhieuThuHocPhi.mssv);
                        command.Parameters.AddWithValue("@SoPhieu", PhieuThuHocPhi.SoPhieu);
                        command.Parameters.AddWithValue("@SoTienThu", decimal.Parse(txtBox_soTien.Text));
                        command.Parameters.AddWithValue("@NgayThu", PhieuThuHocPhi.NgayThu);
                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                    catch (SqlException ex) //Hiển thị ra lỗi nếu query bị lỗi
                    {
                        for (int i = 0; i < ex.Errors.Count; i++)
                        {
                            errorMessages.Append("Index #" + i + "\n" +
                                "Message: " + ex.Errors[i].Message + "\n" +
                                "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                                "Source: " + ex.Errors[i].Source + "\n" +
                                "Procedure: " + ex.Errors[i].Procedure + "\n");
                        }
                        MessageBox.Show(errorMessages.ToString(), "Lỗi");
                    }
                    finally
                    {
                        CapNhatCHUAHTHP();
                    }
                }
            }
        }

        private void CapNhatCHUAHTHP()
        {
            string queryString = "UPDATE CHUAHTHP " +
                "SET SoTienConLai =@SoTienConLai " +
                "WHERE SoPhieu = @SoPhieu ";
            StringBuilder errorMessages = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    command.Parameters.AddWithValue("@SoTienConLai", (PhieuThuHocPhi.SoTienThu - decimal.Parse(txtBox_soTien.Text)));
                    command.Parameters.AddWithValue("@SoPhieu", 3);
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException ex) //Hiển thị ra lỗi nếu query bị lỗi
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Lỗi");
                } 
                finally
                {
                    MessageBox.Show("Đóng học phí thành công!");
                    if (System.Windows.Forms.Application.OpenForms["PhieuThuHocPhi"] != null)
                    {
                        (System.Windows.Forms.Application.OpenForms["PhieuThuHocPhi"] as PhieuThuHocPhi).findSoTienThieu();
                    }
                    this.Close();
                }
            }
        }

        private void txtBox_soTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void number_only_txt(object sender, KeyPressEventArgs e)
        {
            //chi cho so
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
