using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DangKyHocPhan
{
    public partial class TrangchuPDT : Form
    {
        public TrangchuPDT()
        {
            InitializeComponent();
        }

        private void btnQLSV_Click(object sender, EventArgs e)
        {
            QLSV lhs = new QLSV();
            lhs.Show();
        }

        private void btnNDSMH_Click(object sender, EventArgs e)
        {
            DSMonHoc DSMonHoc = new DSMonHoc();
            DSMonHoc.Show();
        }

        private void btnBCSV_Click(object sender, EventArgs e)
        {
            ChuaHTHP hthp = new ChuaHTHP();
            hthp.Show();
        }

        private void Thoat_PDT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi trang phòng đào tạo?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnNDSKN_Click(object sender, EventArgs e)
        {
            Khoa formKhoa = new Khoa();
            formKhoa.Show();
        }

            public event EventHandler DangXuat;
        private void btnDX_Click(object sender, EventArgs e)
        {
            DangXuat(this, new EventArgs());
        }

        private void btnNCTH_Click(object sender, EventArgs e)
        {
            DSChuongTrinhHoc DSChuongTrinhHoc = new DSChuongTrinhHoc();
            DSChuongTrinhHoc.Show();
        }

        private void btnNMHM_Click(object sender, EventArgs e)
        {
            DSMonHocMo DSMonHocMo = new DSMonHocMo();
            DSMonHocMo.Show();
        }
    }
}
