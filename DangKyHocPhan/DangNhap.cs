using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DangKyHocPhan
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        SqlConnection connection2 = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
 

        private void btnDN_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTK.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản", "Tài khoản không được để trống");
                return;
            }

            if (string.IsNullOrEmpty(txtMK.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu không thể để trống");
                return;
            }
            SqlDataAdapter da = new SqlDataAdapter("select * from TAIKHOAN where TenDangNhap=N'" + txtTK.Text + "'and MatKhau=N'" + txtMK.Text + "'", connection2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại tên đăng nhập hoặc mật khẩu", "Tài khoản hoặc mật khẩu không hợp lệ");
            }
            if (dt.Rows[0][2].ToString() == "admin")
            {
                TrangchuPDT f = new TrangchuPDT();
                f.Show();
            }
            else
            {

                TrangchuSV f = new TrangchuSV();
                f.Show();        
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn huỷ bỏ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
