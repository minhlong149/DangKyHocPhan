using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangKyHocPhan
{
    public partial class ChuaHTHP : Form
    {
        public ChuaHTHP()
        {
            InitializeComponent();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_HocKy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            string query = "select PHIEUDK.MaSV, sum(THUHOCPHI.SoTienThu) as [TienDaDong], Sum(CEILING(SoTiet * 1.0 / SoTinChi) * GiaTien) as [TienPhaiDong] from PHIEUDK full join THUHOCPHI on THUHOCPHI.SoPhieu = PHIEUDK.SoPhieu join DKHOCPHAN on DKHOCPHAN.SoPhieu = PHIEUDK.SoPhieu join MONHOC on MONHOC.MaMon = DKHOCPHAN.MonHoc join LOAIMON on LOAIMON.MaLoaiMon = MONHOC.LoaiMon join DSHOCKY on DSHOCKY.MaHK = PHIEUDK.MaHK where DSHOCKY.HocKy = @HocKy and DSHOCKY.NamHoc = @NamHoc group by PHIEUDK.MaSV";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                connection.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter(query, connection);
                sqlDa.SelectCommand.Parameters.AddWithValue("@HocKy", (comboBox_HocKy.Text.ToString() == "Hè" ? "0" : comboBox_HocKy.Text));
                sqlDa.SelectCommand.Parameters.AddWithValue("@NamHoc", comboBoxNamHoc.Text.ToString());

                DataTable dataTable = new DataTable();
                sqlDa.Fill(dataTable);

                dgvChuaHP.DataSource = dataTable;
                connection.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void prepare_comboBox_HocKy()
        {
            string query_HK = "SELECT MaHKC FROM HOCKYCHINH";

            using (SqlDataAdapter adapter = new SqlDataAdapter(query_HK, new SqlConnection(Properties.Settings.Default.DKHPConnectionString)))
            {
                DataTable data = new DataTable();
                adapter.Fill(data);
                data.Columns.Add("HK", typeof(String));

                foreach (DataRow row in data.Rows)
                {
                    row["HK"] = row["MaHKC"].ToString() == "0" ? "Hè" : row["MaHKC"].ToString();
                }

                comboBox_HocKy.DataSource = data;
                comboBox_HocKy.ValueMember = "MaHKC";
                comboBox_HocKy.DisplayMember = "HK";
            }
        }

        private void prepare_comboBox_NamHoc()
        {
            string query_NH = "SELECT DISTINCT NamHoc FROM DSHOCKY ORDER BY NamHoc ASC";
            using (SqlDataAdapter adapter2 = new SqlDataAdapter(query_NH, new SqlConnection(Properties.Settings.Default.DKHPConnectionString)))
            {
                DataTable data = new DataTable();
                adapter2.Fill(data);
                data.Columns.Add("K", typeof(String));

                int idx = 0;
                foreach (DataRow row in data.Rows)
                {
                    row["K"] = idx.ToString();
                    idx += 1;
                }

                comboBoxNamHoc.DataSource = data;
                comboBoxNamHoc.ValueMember = "K";
                comboBoxNamHoc.DisplayMember = "NamHoc";
            }
        }

        private void ChuaHTHP_Load(object sender, EventArgs e)
        {
            prepare_comboBox_HocKy();
            prepare_comboBox_NamHoc();
        }
    }
}
