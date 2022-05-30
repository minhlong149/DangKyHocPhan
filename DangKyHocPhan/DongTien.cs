using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhan
{
    public partial class DongTien : Form
    {
        public DongTien()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_chuyenTien_Click(object sender, EventArgs e)
        {
            string money = txtBox_soTien.Text;
            string message = "Bạn sẽ chuyển đi số tiền " + money + "?";
            MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo);
        }

        private void txtBox_soTien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
