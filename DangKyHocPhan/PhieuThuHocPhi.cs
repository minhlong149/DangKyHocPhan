using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhan
{
    public partial class PhieuThuHocPhi : Form
    {
        public static System.DateTime NgayThu;
        public static string SoPhieu = "";
        public static decimal SoTienThu;
        public static string mssv = TrangchuSV.MSSV.ToString();
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
   
        public PhieuThuHocPhi()
        {
            InitializeComponent();
        }

        private void PhieuThuHocPhi_Load(object sender, EventArgs e)
        {
            txtbox_mssv.Text = mssv;
            fillComboBox();
            ComboBox_SoPhieu.DropDownStyle = ComboBoxStyle.DropDownList;
            //ComboBox_SoPhieu.SelectedIndex = 0;
            findSoTienThieu();
            return;
        }

        public void findSoTienThieu()
        {
            string queryString = "SELECT SoTienConLai FROM dbo.CHUAHTHP where MaSV=@MaSV and SoPhieu = @SoPhieu";
            StringBuilder errorMessages = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    command.Parameters.AddWithValue("@MaSV", mssv);
                    command.Parameters.AddWithValue("@SoPhieu", SoPhieu);

                    connection.Open();

                    SqlDataReader dr;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        SoTienThu = decimal.Parse(dr["SoTienConLai"].ToString());
                        if (SoTienThu==0)
                        {
                            sotienPhaiDong.Text = "Đã Hoàn Thành";
                            btn_dhp.Enabled = false;
                            return;
                        }
                        sotienPhaiDong.Text = dr["SoTienConLai"].ToString().Split('.')[0] + " VNĐ";
                    }
                    connection.Close();
                }
                catch (SqlException ex) //Hiển thị ra lỗi nếu query bị lỗi
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Lỗi");
                }
            }
        }

        private void fillComboBox()
        {
            string queryString = "SELECT DISTINCT SoPhieu FROM dbo.CHUAHTHP where MaSV=@MaSV";
            StringBuilder errorMessages = new StringBuilder();

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                try
                {
                    command.Parameters.AddWithValue("@MaSV", mssv);
                    connection.Open();

                    SqlDataReader dr;
                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        ComboBox_SoPhieu.Items.Add(dr["SoPhieu"]);
                    }
                    connection.Close();
                }
                catch (SqlException ex) //Hiển thị ra lỗi nếu query bị lỗi
                {
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append("Index #" + i + "\n" +
                            "Message: " + ex.Errors[i].Message + "\n" +
                            "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                            "Source: " + ex.Errors[i].Source + "\n" +
                            "Procedure: " + ex.Errors[i].Procedure + "\n");
                    }
                    MessageBox.Show(errorMessages.ToString(), "Lỗi");
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_them_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void button_huy_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grbox_soPhieu_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void date_picker_ngay_lap_ValueChanged(object sender, EventArgs e)
        {

        }
        private void ComboBox_SoPhieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_dhp_Click(object sender, EventArgs e)
        {
            NgayThu = date_picker_ngay_lap.Value;
            SoPhieu = ComboBox_SoPhieu.Text.ToString();
            

            DongTien dt = new DongTien();
            dt.Show();
        }

        private void txtBox_soPhieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void sotienPhaiDong_Click(object sender, EventArgs e)
        {

        }

        private void dgv_Mon_PTHP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void process_event_combobox(object sender, EventArgs e)
        {
            string query = "SELECT MaMon, TenMon " +
                "FROM dbo.DKHocPhan JOIN dbo.MONHOC ON dbo.MONHOC.MaMon = dbo.DKHocPhan.MonHoc " +
                "WHERE SoPhieu = " + ComboBox_SoPhieu.SelectedItem.ToString();
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);

                dgv_Mon_PTHP.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBox_SoPhieu_DropDownClosed(object sender, EventArgs e)
        {
            SoPhieu = ComboBox_SoPhieu.Text.ToString();
            findSoTienThieu();
        }
    }
}
