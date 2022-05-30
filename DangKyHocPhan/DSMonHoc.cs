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
            dgvDSMH.Columns.Clear();
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSMH.DataSource = new Database().SelectData("selectAllMonHoc", lstPara);
            dgvDSMH.AllowUserToAddRows = false;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn(); 
            dgvDSMH.Columns.Insert(4, buttonColumn);
            buttonColumn.HeaderText = "Delete Row";
            buttonColumn.Width = 100;
            buttonColumn.Text = "Xoá";
            buttonColumn.UseColumnTextForButtonValue = true;
        }

        private void DSMonHoc_Load(object sender, EventArgs e)
        {
            LoadDSMH();
            dgvDSMH.Columns["MaMon"].HeaderText = "Mã MH";
            dgvDSMH.Columns["TenMon"].HeaderText = "Tên môn học";
            dgvDSMH.Columns["SoTiet"].HeaderText = "Số Tiết";
            dgvDSMH.Columns["LoaiMon"].HeaderText = "Loại Môn";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            LoadDSMH();
        }

        private void dgvDSMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = dgvDSMH.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn có thực sự muốn xoá?", row.Cells["MaMon"].Value), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<CustomParameter> lstPara = new List<CustomParameter>();
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@mamonhoc",
                        value = dgvDSMH.Rows[e.RowIndex].Cells["MaMon"].Value.ToString(),
                });
                    new Database().SelectData("deleteMonHoc", lstPara);
                LoadDSMH();

            }
        }

        }
    }
}
