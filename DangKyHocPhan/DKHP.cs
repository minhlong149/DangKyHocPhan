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
    public partial class DKHP : Form
    {
        public DKHP()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DKHP_Load(object sender, EventArgs e)
        {
            // Load cboHocKy
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DKHPConnectionString))
            {
                string query = "SELECT * FROM dbo.DSHOCKY ORDER BY NamHoc DESC, HocKy DESC";
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    data.Columns.Add("HienThi", typeof(String));

                    foreach (DataRow row in data.Rows)
                    {
                        row["HienThi"] = ("Học kỳ " + (row["HocKy"].ToString() == "0" ? "hè" : row["HocKy"].ToString()) + " - Năm học " + row["NamHoc"].ToString());
                    }
                    

                    cboHocKy.DataSource = data;
                    cboHocKy.ValueMember = "MaHK";
                    cboHocKy.DisplayMember = "HienThi";
                }
            }
        }
    }
}
