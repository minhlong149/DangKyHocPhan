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

        private void btnNDSMH_Click(object sender, EventArgs e)
        {
            PhieuThuHocPhi PhieuThuHP = new PhieuThuHocPhi();
            PhieuThuHP.Show();
        }
    }
}
