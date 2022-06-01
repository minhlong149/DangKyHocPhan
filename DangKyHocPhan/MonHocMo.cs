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
        public MonHocMo(string mahocky, string mamonhoc)
        {
            this.mahocky = mahocky;
            this.mamonhoc = mamonhoc;
            InitializeComponent();
        }

        private string mahocky;
        private string mamonhoc;
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
            boxMaMH.DataSource = db.SelectData("selectAllChuongTrinhHoc", lst);
            boxMaMH.DisplayMember = "MonHoc";//thuộc tính hiển thị của combobox
            boxMaMH.ValueMember = "MonHoc";//giá trị (key) của combobox
            boxMaMH.SelectedIndex = -1;

            boxMaHK.DataSource = db.SelectData("selectAllChuongTrinhHoc", lst);
            boxMaHK.DisplayMember = "HocKy";
            boxMaHK.ValueMember = "HocKy";
            boxMaHK.SelectedIndex = -1;//set combobox không chọn giá trị nào


            if (string.IsNullOrEmpty(mahocky) || string.IsNullOrEmpty(mamonhoc))
            {
                this.Text = "Thêm mới môn học mở";
            }
            else
            {
                this.Text = "Cập nhật môn học mở";
                var r = db.Select("exec selectMHMo '" + mamonhoc + "', '" + mahocky + "'");
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

        private void button_luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            //ràng buộc điều kiện
            //phải chọn học kỳ và môn học mới tiếp tục thực hiện các câu lệnh phía dưới
            if (boxMaHK.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn mã học kỳ");
                return;
            }
            if (boxMaMH.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }//kết thúc ràng buộc

            List<CustomParameter> lst = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mahocky) || string.IsNullOrEmpty(mamonhoc))
            {
                sql = "insertMonHocMo";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoitao",
                    value = nguoithuchien
                });
            }
            else
            {
                sql = "updateMonHocMo";
                lst.Add(new CustomParameter()
                {
                    key = "@nguoicapnhat",
                    value = nguoithuchien
                });
                lst.Add(new CustomParameter()
                {
                    key = "@mahockybandau",
                    value = mahocky
                });
                lst.Add(new CustomParameter()
                {
                    key = "@mamonhocbandau",
                    value = mamonhoc
                });
            }



            lst.Add(new CustomParameter()
            {
                key = "@mahocky",
                value = boxMaHK.SelectedValue.ToString()//lấy giá trị đc chọn của combobox môn học
            });

            lst.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = boxMaMH.SelectedValue.ToString()//lấy giá trị đc chọn của combobox giáo viên
            });

            var kq = db.ExeCute(sql, lst);
            if (kq == 1)
            {

                if (string.IsNullOrEmpty(mahocky) || string.IsNullOrEmpty(mamonhoc))
                {
                    MessageBox.Show("Thêm mới môn học thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật môn học thành công");
                }

                this.Dispose();

            }
            else
            {
                MessageBox.Show("Lưu dữ liệu thất bại");

            }
        }
    }
}
