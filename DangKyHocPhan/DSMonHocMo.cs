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
    public partial class DSMonHocMo : Form
    {
        public DSMonHocMo()
        {
            InitializeComponent();
        }

        private string tukhoa = "";

        private void LoadDSMHMo()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSMHMo.DataSource = new Database().SelectData("selectAllMonHocMo", lstPara);
        }

        private void DSMonHocMo_Load(object sender, EventArgs e)
        {
            LoadDSMHMo();
            dgvDSMHMo.Columns["MaHK"].HeaderText = "Mã học kỳ";
            dgvDSMHMo.Columns["MonHoc"].HeaderText = "Mã môn học";
        }

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            LoadDSMHMo();
        }

        private void btnThemmoi_Click_1(object sender, EventArgs e)
        {
            new MonHocMo(null, null).ShowDialog();
            LoadDSMHMo();
        }

        private void dgvDSMHMo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mahk = dgvDSMHMo.Rows[e.RowIndex].Cells["MaHK"].Value.ToString();
                var mamh = dgvDSMHMo.Rows[e.RowIndex].Cells["MonHoc"].Value.ToString();
                new MonHocMo(mahk, mamh).ShowDialog();
                LoadDSMHMo();
            }
        }
    }
}
