using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DangKyHocPhan
{
    public partial class TrangchuPDT : DangKyHocPhan.Form1
    {
        public TrangchuPDT()
        {
            InitializeComponent();
        }

        private void btnLHSSV_Click(object sender, EventArgs e)
        {
            LapHSSV lhs = new LapHSSV();
            lhs.Show();
        }

<<<<<<< HEAD
        private void btnNDSMH_Click(object sender, EventArgs e)
        {
            PhieuThuHocPhi PhieuThuHP = new PhieuThuHocPhi();
            PhieuThuHP.Show();
=======
        private void Thoat_PDT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TrangchuPDT_Load(object sender, EventArgs e)
        {

        }

        private void btnBCSV_Click(object sender, EventArgs e)
        {
            ChuaHTHP cthp = new ChuaHTHP();
            cthp.Show();
>>>>>>> 94e6906203781bbc23bdf47ec82b711a126893e7
        }
    }
}
