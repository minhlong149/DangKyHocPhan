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
        private void LapHSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dKHPDataSet.NGANH' table. You can move, or remove it, as needed.
            this.nGANHTableAdapter.Fill(this.dKHPDataSet.NGANH);
            // TODO: This line of code loads data into the 'dKHPDataSet.DOITUONG' table. You can move, or remove it, as needed.
            this.dOITUONGTableAdapter.Fill(this.dKHPDataSet.DOITUONG);
            // TODO: This line of code loads data into the 'dKHPDataSet.TINH' table. You can move, or remove it, as needed.
            this.tINHTableAdapter.Fill(this.dKHPDataSet.TINH);
            connection2 = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
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
            string checkbtn = "";
            if (string.IsNullOrEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số sinh viên", "Mã số sinh viên không thể để trống");
                return;
            }
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên", "Họ và tên không thể để trống");
                return;
            }
            if (rbtnNam.Checked==true)
            {
                checkbtn = checkbtn + rbtnNam.Text;
            }
            if (rbtnNu.Checked == true)
            {
                checkbtn = checkbtn + rbtnNu.Text;
            }
            if (checkbtn.Length==0)
            {
                MessageBox.Show("Vui lòng chọn giới tính của sinh viên!");
            }
            if (connection2==null)
            {
                connection2 = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
            }
            if(connection2.State==ConnectionState.Closed)
            {
                connection2.Open();
            }
            int gt;
            if(checkbtn=="Nam")
            {
                gt = 1;
            }
            else
            {
                gt = 0;
            }
            SqlCommand cmdlhs = new SqlCommand();
            cmdlhs.CommandType = CommandType.Text;
            DateTime date = pickNS.Value;
            string lhstxt = "insert into SINHVIEN (MaSV,TenSV,GioiTinh,NgaySinh,DoiTuong,Huyen,Tinh,NganhHoc)"+"values ('" + txtMSSV.Text + "',N'" + txtHoTen.Text + "','" + gt + "','" + date + "','" + CBoxDT.Text + "','" + CBoxHuyen.Text + "','" + CBoxTinh.Text + "','" + CBoxNganh.Text + "')";
            cmdlhs.CommandText = lhstxt;
            cmdlhs.Connection = connection2;
            int n = cmdlhs.ExecuteNonQuery();
            if (n>0)
            {
                MessageBox.Show("Hoàn tất lưu hồ sơ sinh viên!");
            }
            else
            {
                MessageBox.Show("Lưu hồ sơ sinh viên thất bại!");
            }
        }
    }
}
