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
    public partial class ChuongTrinhHoc : Form
    {
        public ChuongTrinhHoc(string nganhhoc, string khoa, int hocky, string monhoc)
        {
            this.nganhhoc = nganhhoc;
            this.khoa = khoa;
            this.hocky = hocky;
            this.monhoc = monhoc;
            InitializeComponent();
        }

        private string nganhhoc;
        private string khoa;
        private int hocky;
        private string monhoc;
        private Database db;

        private void ChuongTrinhHoc_Load(object sender, EventArgs e)
        {
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
                boxNganhHoc.DataSource = db.SelectData("selectNganhHoc", lst);
                boxNganhHoc.DisplayMember = "TenNganh";//thuộc tính hiển thị của combobox
                boxNganhHoc.ValueMember = "MaNganh";//giá trị (key) của combobox
                boxNganhHoc.SelectedIndex = -1;


                boxKhoa.DataSource = db.SelectData("selectKhoa", lst);
                boxKhoa.DisplayMember = "TenKhoa";//thuộc tính hiển thị của combobox
                boxKhoa.ValueMember = "MaKhoa";//giá trị (key) của combobox
                boxKhoa.SelectedIndex = -1;


                boxMonHoc.DataSource = db.SelectData("selectAllMonHoc", lst);
                boxMonHoc.DisplayMember = "TenMon";
                boxMonHoc.ValueMember = "MaMon";
                boxMonHoc.SelectedIndex = -1;//set combobox không chọn giá trị nào



                if (string.IsNullOrEmpty(nganhhoc) && string.IsNullOrEmpty(khoa) && string.IsNullOrEmpty(monhoc))
                {
                    this.Text = "Thêm mới chương trình học";
                }
                else
                {
                    this.Text = "Cập nhật chương trình học";
                    var r = db.Select("exec selectChuongTrinhHoc '" + nganhhoc + "', '" + khoa + "', '" + hocky + "', '" + monhoc +"'");
                    boxNganhHoc.SelectedValue = r["NganhHoc"].ToString();
                    boxKhoa.SelectedValue = r["Khoa"].ToString();
                    txtHocKy.Text = r["HocKy"].ToString();
                    boxMonHoc.SelectedValue = r["MonHoc"].ToString();
                }

            }
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            string sql = "";

            //ràng buộc điều kiện
            //phải chọn học kỳ và môn học mới tiếp tục thực hiện các câu lệnh phía dưới
            if (boxNganhHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn ngành học");
                return;
            }
            if (boxKhoa.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn khoa");
                return;
            }
            if (txtHocKy == null)
            {
                MessageBox.Show("Vui lòng nhập học kỳ");
                return;
            }
            if (boxMonHoc.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn môn học");
                return;
            }//kết thúc ràng buộc

            List<CustomParameter> lst = new List<CustomParameter>();
            if (string.IsNullOrEmpty(nganhhoc) && string.IsNullOrEmpty(khoa) && string.IsNullOrEmpty(monhoc))
            {
                sql = "insertChuongTrinhHoc";
                lst.Add(new CustomParameter()
                {
                    key = "@hocky",
                    value = txtHocKy.Text
                }); ;
            }
            else
            {
                sql = "updateChuongTrinhHoc";
                lst.Add(new CustomParameter()
                {
                    key = "@manganhbandau",
                    value = nganhhoc
                });
                lst.Add(new CustomParameter()
                {
                    key = "@makhoabandau",
                    value = khoa
                });
                lst.Add(new CustomParameter()
                {
                    key = "@mamonbandau",
                    value = monhoc
                });
                lst.Add(new CustomParameter()
                {
                    key = "@hocky",
                    value = hocky.ToString()
                });
            }



            lst.Add(new CustomParameter()
            {
                key = "@manganh",
                value = boxNganhHoc.SelectedValue.ToString()//lấy giá trị đc chọn của combobox môn học
            });

            lst.Add(new CustomParameter()
            {
                key = "@makhoa",
                value = boxKhoa.SelectedValue.ToString()//lấy giá trị đc chọn của combobox giáo viên
            });

            lst.Add(new CustomParameter()
            {
                key = "@mamonhoc",
                value = boxMonHoc.SelectedValue.ToString()//lấy giá trị đc chọn của combobox giáo viên
            });




            var kq = db.ExeCute(sql, lst);
            if (kq == 1)
            {

                if (string.IsNullOrEmpty(nganhhoc) && string.IsNullOrEmpty(khoa) && string.IsNullOrEmpty(monhoc))
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
