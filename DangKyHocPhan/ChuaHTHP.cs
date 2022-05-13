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
    public partial class ChuaHTHP : Form
    {
        public ChuaHTHP()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_HocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Truy Vấn Thành Công");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
