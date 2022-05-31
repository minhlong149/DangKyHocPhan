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
using System.Configuration;
using System.Globalization;

namespace DangKyHocPhan
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
            SqlConnection connection2 = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
            string sql = "select * from TINH";
            SqlCommand cmd= new SqlCommand(sql,connection2);
            connection2.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CBoxTinh.ValueMember = "MaTinh";
            CBoxTinh.DisplayMember = "TenTinh";
            CBoxTinh.DataSource = dt;
            CBoxHuyen.Enabled = false;
        }
        
        private string tukhoa = "";
        public object Database { get; private set; }

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
            dgvSV.Columns["TenDT"].HeaderText = "Đối tượng miễn giảm";
            dgvSV.Columns["TenHuyen"].HeaderText = "Huyện";
            dgvSV.Columns["TenTinh"].HeaderText = "Tỉnh";
            dgvSV.Columns["TenNganh"].HeaderText = "Ngành học";
            // TODO: This line of code loads data into the 'dKHPDataSet.NGANH' table. You can move, or remove it, as needed.
            this.nGANHTableAdapter.Fill(this.dKHPDataSet.NGANH);
            // TODO: This line of code loads data into the 'dKHPDataSet.DOITUONG' table. You can move, or remove it, as needed.
            this.dOITUONGTableAdapter.Fill(this.dKHPDataSet.DOITUONG);
            // TODO: This line of code loads data into the 'dKHPDataSet.TINH' table. You can move, or remove it, as needed.
            this.tINHTableAdapter.Fill(this.dKHPDataSet.TINH);
        }
        private void CBoxTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CBoxTinh.SelectedValue.ToString()!=null)
            {
                SqlConnection connection2 = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
                string sql = "select * from HUYEN where ThuocTinh=@ThuocTinh";
                SqlCommand cmd = new SqlCommand(sql, connection2);
                connection2.Open();
                cmd.Parameters.AddWithValue("@ThuocTinh", CBoxTinh.SelectedValue.ToString());
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                CBoxHuyen.ValueMember = "MaHuyen";
                CBoxHuyen.DisplayMember = "TenHuyen";
                CBoxHuyen.DataSource = dt;
                CBoxHuyen.Enabled = true;
            }
        }

        private void btnLHS_Click(object sender, EventArgs e)
        { 
            string MaSV=txtMSSV.Text;
            string sql = "";
            string sql1 = "";
            string hoten = txtHoTen.Text;
            string ngaysinh =pickNS.Value.ToShortDateString();
            string gioitinh = rbtnNam.Checked ? "1" : "0";
            string doituong = CBoxDT.SelectedValue.ToString();
            string huyen = CBoxHuyen.SelectedValue.ToString();
            string tinh = CBoxTinh.SelectedValue.ToString();
            string nganh = CBoxNganh.SelectedValue.ToString();
            Load_DSSV();
            //Kiem tra MSSV da ton tai chua ?
            SqlConnection connection2 = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
            string sqlmasv = "select * from SINHVIEN where MaSV=@MaSV";
            SqlCommand cmd = new SqlCommand(sqlmasv, connection2);
            connection2.Open();
            cmd.Parameters.AddWithValue("@MaSV", txtMSSV.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (string.IsNullOrEmpty(txtMSSV.Text))
            {
                MessageBox.Show("Mã số sinh viên không được để trống");
                txtMSSV.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống");
                txtHoTen.Select();
                return;
            }

            //khai báo một danh sách tham sô
            List<CustomParameter> lstPara = new List<CustomParameter>();
            List<CustomParameter> lstPara1 = new List<CustomParameter>();
            if (dt.Rows.Count==0)//nếu thêm mới sinh viên
            {
                sql = "ThemSV";//gọi tới procedure thêm mới sinh viên
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaSV",
                    value = MaSV
                });
                sql1 = "ThemTK";
                lstPara1.Add(new CustomParameter()
                {
                    key = "@TenDangNhap",
                    value = MaSV
                });
            }
            else//nếu cập nhật sinh viên
            {
                sql = "UPDATESV";//gọi tới procedure cập nhật sinh viên
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaSV",
                    value = MaSV
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@TenSV",
                value = hoten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NgaySinh",
                value = ngaysinh
            }); ;
            lstPara.Add(new CustomParameter()
            {
                key = "@GioiTinh",
                value = gioitinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DoiTuong",
                value = doituong
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Huyen",
                value = huyen
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@Tinh",
                value = tinh
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@NganhHoc",
                value = nganh
            });


            var rs = new Database().ExeCute(sql, lstPara);//truyền 2 tham số là câu lệnh sql
            //và danh sách các tham số
            if (rs == 1)
            {
                if (dt.Rows.Count == 0)//nếu thêm mới
                {
                    MessageBox.Show("Thêm mới sinh viên thành công");
                }
                else//nếu cập nhật
                {
                    MessageBox.Show("Cập nhật thông tin sinh viên thành công");
                }
                Load_DSSV();
            }
            else//nếu không thành công
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }


        private void dgvSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMSSV.Text = this.dgvSV.CurrentRow.Cells[0].Value.ToString();
            txtMSSV.Enabled = false;
            txtHoTen.Text = this.dgvSV.CurrentRow.Cells[1].Value.ToString();
            pickNS.Text = this.dgvSV.CurrentRow.Cells[2].Value.ToString();
            if (this.dgvSV.CurrentRow.Cells[3].Value.ToString() == "Nam")
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
            if (MessageBox.Show("Bạn có chắc chắn thoát khỏi trang quản lý sinh viên?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
             tukhoa = txtTukhoa.Text;
             Load_DSSV();
        }

        private void btnXoaHS_Click(object sender, EventArgs e)
        {
            string sql = "";
            string sql1 = "";
            SqlConnection connection2 = new SqlConnection(Properties.Settings.Default.DKHPConnectionString);
            string sqlmasv = "select * from SINHVIEN where MaSV=@MaSV";
            SqlCommand cmd = new SqlCommand(sqlmasv, connection2);
            connection2.Open();
            cmd.Parameters.AddWithValue("@MaSV", txtMSSV.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            List<CustomParameter> lstPara = new List<CustomParameter>();
            List<CustomParameter> lstPara1 = new List<CustomParameter>();
            if (dt.Rows.Count == 1)
            {
                sql = "XoaSV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaSV",
                    value = txtMSSV.Text
                });
                sql1 = "XoaTK";
                lstPara1.Add(new CustomParameter()
                {
                    key = "@TenDangNhap",
                    value = txtMSSV.Text
                });
            }
            else
            {
                MessageBox.Show("Mã số sinh viên không tồn tại!");
            }
            var rs = new Database().ExeCute(sql, lstPara);
            var rs1 = new Database().ExeCute(sql1, lstPara1);
            if (rs == 1)
            {
                MessageBox.Show("Xoá sinh viên thành công");
                Load_DSSV();
            }
            else//nếu không thành công
            {
                MessageBox.Show("Thực thi thất bại");
            }
        }

        private void btnLapHS_Click(object sender, EventArgs e)
        {
            txtMSSV.Enabled = true;
            txtMSSV.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            rbtnNam.Checked = false;
            rbtnNu.Checked = false;
            pickNS.Text = string.Empty;
            CBoxDT.Text = string.Empty;
        }
    }
}
