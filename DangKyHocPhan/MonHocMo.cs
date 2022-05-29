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
    public partial class MonHocMo : Form
    {
        public MonHocMo(string mahk, string mamh)
        {
            this.mahk = mahk;
            this.mamh = mamh;
            InitializeComponent();
        }

        private string mahk;
        private string mamh;
        private Database db;
        private string nguoithuchien = "admin";

        private void MonHocMo_Load_1(object sender, EventArgs e)
        {
            db = new Database();
            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@tukhoa",
                    value=""
                }
            };
            //load dữ liệu cho 2 combobox học kỳ và môn học
            boxMaMH.DataSource = db.SelectData("selectAllMonHoc", lst);
            boxMaMH.DisplayMember = "TenMon";//thuộc tính hiển thị của combobox
            boxMaMH.ValueMember = "MaMon";//giá trị (key) của combobox
            boxMaMH.SelectedIndex = -1;

            boxMaHK.DataSource = db.SelectData("selectHK", lst);
            boxMaHK.DisplayMember = "HocKy";
            boxMaHK.ValueMember = "MaHK";
            boxMaHK.SelectedIndex = -1;//set combobox không chọn giá trị nào


            if (string.IsNullOrEmpty(mahk) || string.IsNullOrEmpty(mamh))
            {
                this.Text = "Thêm mới môn học mở";
            }
            else
            {
                this.Text = "Cập nhật môn học mở";
                var r = db.Select("exec selectMHMo '" + mamh + mahk + "'");
                boxMaHK.SelectedValue = r["MaHK"].ToString();
                boxMaMH.SelectedValue = r["MonHoc"].ToString();
            }

        }

        private void boxMaHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
