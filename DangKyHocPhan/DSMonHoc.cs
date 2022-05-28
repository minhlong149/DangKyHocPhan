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
    public partial class DSMonHoc : Form
    {
        public DSMonHoc()
        {
            InitializeComponent();
        }

        private string tukhoa = "";

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new MonHoc(null).ShowDialog();
            LoadDSMH();
        }

        private void dgvDSMH_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mamh = dgvDSMH.Rows[e.RowIndex].Cells["MaMon"].Value.ToString();
                new MonHoc(mamh).ShowDialog();
                LoadDSMH();
            }
        }

        private void LoadDSMH()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSMH.DataSource = new Database().SelectData("selectAllMonHoc", lstPara);
        }

        private void DSMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSMH();
            dgvDSMH.Columns["MaMon"].HeaderText = "Mã môn học";
            dgvDSMH.Columns["TenMon"].HeaderText = "Tên môn học";
            dgvDSMH.Columns["SoTiet"].HeaderText = "Số tiết";
            dgvDSMH.Columns["LoaiMon"].HeaderText = "Loại môn";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            LoadDSMH();
        }


    }
}
