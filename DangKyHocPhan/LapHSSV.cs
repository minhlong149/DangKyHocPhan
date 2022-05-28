using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DangKyHocPhan
{
    public partial class LapHSSV : Form
    {
        public LapHSSV()
        {
            InitializeComponent();
        }
        SqlConnection connection2;
        SqlDataReader dr;
        SqlCommand cmd;
        string sql;
        private string tukhoa = "";
        public object Database { get; private set; }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Load_DSSV()
        {
            List<CustomParameter> lstPara = new List<CustomParameter>();
            lstPara.Add(new CustomParameter()
            {
                key = "@tukhoa",
                value = tukhoa
            });
            dgvSV.DataSource = new Database().SelectData("selectAllSinhVien", lstPara);
        }

        private void LapHSSV_Load(object sender, EventArgs e)
        {
            Load_DSSV();
            dgvSV.Columns["MaSV"].HeaderText = "Mã số sinh viên";
            dgvSV.Columns["TenSV"].HeaderText = "Họ và tên";
            dgvSV.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dgvSV.Columns["GioiTinh"].HeaderText = "Giới tính";
            dgvSV.Columns["DoiTuong"].HeaderText = "Đối tượng miễn giảm";
            dgvSV.Columns["Huyen"].HeaderText = "Huyện";
            dgvSV.Columns["Tinh"].HeaderText = "Tỉnh";
            dgvSV.Columns["NganhHoc"].HeaderText = "Ngành học";
            // TODO: This line of code loads data into the 'dKHPDataSet.NGANH' table. You can move, or remove it, as needed.
            this.nGANHTableAdapter.Fill(this.dKHPDataSet.NGANH);
            // TODO: This line of code loads data into the 'dKHPDataSet.DOITUONG' table. You can move, or remove it, as needed.
            this.dOITUONGTableAdapter.Fill(this.dKHPDataSet.DOITUONG);
            // TODO: This line of code loads data into the 'dKHPDataSet.TINH' table. You can move, or remove it, as needed.
            this.tINHTableAdapter.Fill(this.dKHPDataSet.TINH);
        }
        private void CBoxTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection2.Open();
            CBoxHuyen.Items.Clear();
            sql = @"SELECT TINH.TenTinh,HUYEN.TenHuyen
                    FROM TINH Inner Join HUYEN
                    ON TINH.MaTinh=HUYEN.ThuocTinh
                    WHERE(TINH.TenTinh=N'" + CBoxTinh.Text + @"')";
            cmd = new SqlCommand(sql, connection2);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CBoxHuyen.Items.Add(dr[1].ToString());
            }
            connection2.Close();
        }

        private void btnLHS_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMSSV.Text = this.dgvSV.CurrentRow.Cells[0].Value.ToString();
            txtHoTen.Text = this.dgvSV.CurrentRow.Cells[1].Value.ToString();
            pickNS.Text = this.dgvSV.CurrentRow.Cells[2].Value.ToString();
            if (this.dgvSV.CurrentRow.Cells[3].Value.ToString() == "1")
            {
                rbtnNam.Checked = true;
            }
            else
            {
                rbtnNu.Checked = true;
            }
            CBoxDT.Text = this.dgvSV.CurrentRow.Cells[4].Value.ToString();
            CBoxHuyen.Text = this.dgvSV.CurrentRow.Cells[5].Value.ToString();
            CBoxTinh.Text = this.dgvSV.CurrentRow.Cells[6].Value.ToString();
            CBoxNganh.Text = this.dgvSV.CurrentRow.Cells[7].Value.ToString();
            Load_DSSV();
        }

        private void btnThoatLHS_Click(object sender, EventArgs e)
        {
        }
    }
}
