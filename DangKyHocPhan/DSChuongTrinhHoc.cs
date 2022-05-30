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
    public partial class DSChuongTrinhHoc: Form
    {
        public DSChuongTrinhHoc()
        {
            InitializeComponent();
        }

        private string tukhoa = "";

        private void LoadDSCTHoc()
        {
            dgvDSCTHoc.Columns.Clear();
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvDSCTHoc.DataSource = new Database().SelectData("selectAllChuongTrinhHoc", lstPara);
            dgvDSCTHoc.AllowUserToAddRows = false;
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            dgvDSCTHoc.Columns.Insert(4, buttonColumn);
            buttonColumn.HeaderText = "Delete Row";
            buttonColumn.Width = 100;
            buttonColumn.Text = "Xoá";
            buttonColumn.UseColumnTextForButtonValue = true;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tukhoa = txtTimKiem.Text;
            LoadDSCTHoc();
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new ChuongTrinhHoc(null, null, 0, null).ShowDialog();
            LoadDSCTHoc();
        }

        private void DSChuongTrinhHoc_Load(object sender, EventArgs e)
        {
            LoadDSCTHoc();
        }

        private void dgvDSCTHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                DataGridViewRow row = dgvDSCTHoc.Rows[e.RowIndex];
                if (MessageBox.Show(string.Format("Bạn có thực sự muốn xoá?", row.Cells["NganhHoc"].Value, row.Cells["Khoa"].Value, row.Cells["HocKy"].Value, row.Cells["MonHoc"].Value), "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    List<CustomParameter> lstPara = new List<CustomParameter>();
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@manganh",
                        value = dgvDSCTHoc.Rows[e.RowIndex].Cells["NganhHoc"].Value.ToString(),
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@makhoa",
                        value = dgvDSCTHoc.Rows[e.RowIndex].Cells["Khoa"].Value.ToString(),
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@hocky",
                        value = dgvDSCTHoc.Rows[e.RowIndex].Cells["HocKy"].Value.ToString(),
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@mamonhoc",
                        value = dgvDSCTHoc.Rows[e.RowIndex].Cells["MonHoc"].Value.ToString(),
                    });
                    new Database().SelectData("deleteChuongTrinhHoc", lstPara);
                    LoadDSCTHoc();
                }
            }
        }

        private void dgvDSCTHoc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var manganh = dgvDSCTHoc.Rows[e.RowIndex].Cells["NganhHoc"].Value.ToString();
                var makhoa = dgvDSCTHoc.Rows[e.RowIndex].Cells["Khoa"].Value.ToString();
                var mamh = dgvDSCTHoc.Rows[e.RowIndex].Cells["MonHoc"].Value.ToString();
                var hocky = int.Parse(dgvDSCTHoc.Rows[e.RowIndex].Cells["HocKy"].Value.ToString());
                new ChuongTrinhHoc(manganh, makhoa, hocky, mamh).ShowDialog();
                LoadDSCTHoc();
            }
        }
    }
}
