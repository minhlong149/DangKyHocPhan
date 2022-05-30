
namespace DangKyHocPhan
{
    partial class TrangchuPDT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangchuPDT));
            this.Thoat_PDT = new System.Windows.Forms.Button();
            this.btnQLSV = new System.Windows.Forms.Button();
            this.btnNDSMH = new System.Windows.Forms.Button();
            this.btnNCTH = new System.Windows.Forms.Button();
            this.btnNMHM = new System.Windows.Forms.Button();
            this.btnBCSV = new System.Windows.Forms.Button();
            this.btnNDSKN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Thoat_PDT
            // 
            this.Thoat_PDT.BackColor = System.Drawing.Color.White;
            this.Thoat_PDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat_PDT.Location = new System.Drawing.Point(623, 395);
            this.Thoat_PDT.Name = "Thoat_PDT";
            this.Thoat_PDT.Size = new System.Drawing.Size(100, 29);
            this.Thoat_PDT.TabIndex = 7;
            this.Thoat_PDT.Text = "Thoát";
            this.Thoat_PDT.UseVisualStyleBackColor = false;
            this.Thoat_PDT.Click += new System.EventHandler(this.Thoat_PDT_Click);
            // 
            // btnQLSV
            // 
            this.btnQLSV.BackColor = System.Drawing.Color.White;
            this.btnQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLSV.Location = new System.Drawing.Point(138, 215);
            this.btnQLSV.Name = "btnQLSV";
            this.btnQLSV.Size = new System.Drawing.Size(287, 38);
            this.btnQLSV.TabIndex = 11;
            this.btnQLSV.Text = "Quản lý sinh viên";
            this.btnQLSV.UseVisualStyleBackColor = false;
            this.btnQLSV.Click += new System.EventHandler(this.btnQLSV_Click);
            // 
            // btnNDSMH
            // 
            this.btnNDSMH.BackColor = System.Drawing.Color.White;
            this.btnNDSMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNDSMH.Location = new System.Drawing.Point(138, 274);
            this.btnNDSMH.Name = "btnNDSMH";
            this.btnNDSMH.Size = new System.Drawing.Size(287, 38);
            this.btnNDSMH.TabIndex = 12;
            this.btnNDSMH.Text = "Nhập danh sách môn học";
            this.btnNDSMH.UseVisualStyleBackColor = false;
            this.btnNDSMH.Click += new System.EventHandler(this.btnNDSMH_Click);
            // 
            // btnNCTH
            // 
            this.btnNCTH.BackColor = System.Drawing.Color.White;
            this.btnNCTH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCTH.Location = new System.Drawing.Point(138, 330);
            this.btnNCTH.Name = "btnNCTH";
            this.btnNCTH.Size = new System.Drawing.Size(287, 38);
            this.btnNCTH.TabIndex = 13;
            this.btnNCTH.Text = "Nhập chương trình học";
            this.btnNCTH.UseVisualStyleBackColor = false;
            // 
            // btnNMHM
            // 
            this.btnNMHM.BackColor = System.Drawing.Color.White;
            this.btnNMHM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNMHM.Location = new System.Drawing.Point(463, 215);
            this.btnNMHM.Name = "btnNMHM";
            this.btnNMHM.Size = new System.Drawing.Size(310, 38);
            this.btnNMHM.TabIndex = 14;
            this.btnNMHM.Text = "Nhập môn học mở trong học kì";
            this.btnNMHM.UseVisualStyleBackColor = false;
            // 
            // btnBCSV
            // 
            this.btnBCSV.BackColor = System.Drawing.Color.White;
            this.btnBCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBCSV.Location = new System.Drawing.Point(463, 330);
            this.btnBCSV.Name = "btnBCSV";
            this.btnBCSV.Size = new System.Drawing.Size(310, 38);
            this.btnBCSV.TabIndex = 15;
            this.btnBCSV.Text = "Báo cáo sinh viên chưa đóng học phí";
            this.btnBCSV.UseVisualStyleBackColor = false;
            this.btnBCSV.Click += new System.EventHandler(this.btnBCSV_Click);
            // 
            // btnNDSKN
            // 
            this.btnNDSKN.BackColor = System.Drawing.Color.White;
            this.btnNDSKN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNDSKN.Location = new System.Drawing.Point(463, 274);
            this.btnNDSKN.Name = "btnNDSKN";
            this.btnNDSKN.Size = new System.Drawing.Size(310, 38);
            this.btnNDSKN.TabIndex = 16;
            this.btnNDSKN.Text = "Nhập danh sách khoa và ngành";
            this.btnNDSKN.UseVisualStyleBackColor = false;
            this.btnNDSKN.Click += new System.EventHandler(this.btnNDSKN_Click);
            // 
            // TrangchuPDT
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNDSKN);
            this.Controls.Add(this.btnBCSV);
            this.Controls.Add(this.btnNMHM);
            this.Controls.Add(this.btnNCTH);
            this.Controls.Add(this.btnNDSMH);
            this.Controls.Add(this.btnQLSV);
            this.Controls.Add(this.Thoat_PDT);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TrangchuPDT";
            this.Text = "Trang Chủ Phòng Đào Tạo";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Thoat_PDT;
        private System.Windows.Forms.Button btnQLSV;
        private System.Windows.Forms.Button btnNDSMH;
        private System.Windows.Forms.Button btnNCTH;
        private System.Windows.Forms.Button btnNMHM;
        private System.Windows.Forms.Button btnBCSV;
        private System.Windows.Forms.Button btnNDSKN;
    }
}
