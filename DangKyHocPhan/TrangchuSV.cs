using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DangKyHocPhan
{
    public partial class TrangchuSV : Form
    {
        // Lưu lại MSSV của SV sau khi đăng nhập
        // DKHP và thu học phí sẽ trỏ vào sinh viên này
        // -> Không cần phải nhập MSSV
        public static String MSSV;

        public TrangchuSV()
        {
            InitializeComponent();
        }

        private void TrangchuSV_Load(object sender, EventArgs e)
        {

        }

        private void btnDKHP_Click(object sender, EventArgs e)
        {
            DKHP dk = new DKHP();
            dk.Show();
        }

        private void btnXPTHP_Click(object sender, EventArgs e)
        {
            PhieuThuHocPhi pt = new PhieuThuHocPhi();
            pt.Show();
        }

        private void btnThoatSV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi trang sinh viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
