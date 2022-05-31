namespace DangKyHocPhan
{
    partial class ChuaHTHP
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.grBoxThongTin = new System.Windows.Forms.GroupBox();
            this.comboBoxNamHoc = new System.Windows.Forms.ComboBox();
            this.btnTruyVan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_HocKy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvChuaHP = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienPhaiDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTienConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.grBoxThongTin.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuaHP)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 51);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(42, 19);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(519, 19);
            this.title.TabIndex = 0;
            this.title.Text = "DANH SÁCH SINH VIÊN CHƯA HOÀN THÀNH VIỆC ĐÓNG HỌC PHÍ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // grBoxThongTin
            // 
            this.grBoxThongTin.Controls.Add(this.comboBoxNamHoc);
            this.grBoxThongTin.Controls.Add(this.btnTruyVan);
            this.grBoxThongTin.Controls.Add(this.label2);
            this.grBoxThongTin.Controls.Add(this.comboBox_HocKy);
            this.grBoxThongTin.Controls.Add(this.label1);
            this.grBoxThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grBoxThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxThongTin.Location = new System.Drawing.Point(0, 51);
            this.grBoxThongTin.Name = "grBoxThongTin";
            this.grBoxThongTin.Size = new System.Drawing.Size(628, 75);
            this.grBoxThongTin.TabIndex = 1;
            this.grBoxThongTin.TabStop = false;
            this.grBoxThongTin.Text = "Thông tin năm học";
            this.grBoxThongTin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxNamHoc
            // 
            this.comboBoxNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNamHoc.FormattingEnabled = true;
            this.comboBoxNamHoc.Location = new System.Drawing.Point(99, 47);
            this.comboBoxNamHoc.Name = "comboBoxNamHoc";
            this.comboBoxNamHoc.Size = new System.Drawing.Size(118, 26);
            this.comboBoxNamHoc.TabIndex = 3;
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTruyVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruyVan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTruyVan.Location = new System.Drawing.Point(530, 38);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(75, 35);
            this.btnTruyVan.TabIndex = 4;
            this.btnTruyVan.Text = "Tìm";
            this.btnTruyVan.UseVisualStyleBackColor = false;
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Năm học";
            // 
            // comboBox_HocKy
            // 
            this.comboBox_HocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_HocKy.FormattingEnabled = true;
            this.comboBox_HocKy.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_HocKy.Location = new System.Drawing.Point(99, 18);
            this.comboBox_HocKy.Name = "comboBox_HocKy";
            this.comboBox_HocKy.Size = new System.Drawing.Size(118, 26);
            this.comboBox_HocKy.TabIndex = 1;
            this.comboBox_HocKy.SelectedIndexChanged += new System.EventHandler(this.comboBox_HocKy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học kỳ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnThoat.Location = new System.Drawing.Point(530, 3);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 34);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvChuaHP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 214);
            this.panel2.TabIndex = 3;
            // 
            // dgvChuaHP
            // 
            this.dgvChuaHP.AllowUserToAddRows = false;
            this.dgvChuaHP.AllowUserToDeleteRows = false;
            this.dgvChuaHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuaHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.SoPhieu,
            this.SoTienDangKy,
            this.SoTienPhaiDong,
            this.SoTienConLai,
            this.HocKy,
            this.NamHoc});
            this.dgvChuaHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuaHP.Location = new System.Drawing.Point(0, 0);
            this.dgvChuaHP.Margin = new System.Windows.Forms.Padding(100);
            this.dgvChuaHP.Name = "dgvChuaHP";
            this.dgvChuaHP.ReadOnly = true;
            this.dgvChuaHP.Size = new System.Drawing.Size(628, 214);
            this.dgvChuaHP.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnThoat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 340);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(628, 44);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // MaSV
            // 
            this.MaSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã số sinh viên";
            this.MaSV.Name = "MaSV";
            this.MaSV.ReadOnly = true;
            this.MaSV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SoPhieu
            // 
            this.SoPhieu.DataPropertyName = "SoPhieu";
            this.SoPhieu.HeaderText = "Số Phiếu";
            this.SoPhieu.Name = "SoPhieu";
            this.SoPhieu.ReadOnly = true;
            this.SoPhieu.Visible = false;
            // 
            // SoTienDangKy
            // 
            this.SoTienDangKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTienDangKy.DataPropertyName = "SoTienDangKy";
            this.SoTienDangKy.HeaderText = "Số Tiền Đăng Ký";
            this.SoTienDangKy.Name = "SoTienDangKy";
            this.SoTienDangKy.ReadOnly = true;
            this.SoTienDangKy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SoTienPhaiDong
            // 
            this.SoTienPhaiDong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTienPhaiDong.DataPropertyName = "SoTienPhaiDong";
            this.SoTienPhaiDong.HeaderText = "Số Tiền Phải Đóng";
            this.SoTienPhaiDong.Name = "SoTienPhaiDong";
            this.SoTienPhaiDong.ReadOnly = true;
            this.SoTienPhaiDong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // SoTienConLai
            // 
            this.SoTienConLai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SoTienConLai.DataPropertyName = "SoTienConLai";
            this.SoTienConLai.HeaderText = "Số Tiền Còn Lại";
            this.SoTienConLai.Name = "SoTienConLai";
            this.SoTienConLai.ReadOnly = true;
            this.SoTienConLai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // HocKy
            // 
            this.HocKy.DataPropertyName = "HocKy";
            this.HocKy.HeaderText = "Học Kỳ";
            this.HocKy.Name = "HocKy";
            this.HocKy.ReadOnly = true;
            this.HocKy.Visible = false;
            // 
            // NamHoc
            // 
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.HeaderText = "Năm học";
            this.NamHoc.Name = "NamHoc";
            this.NamHoc.ReadOnly = true;
            this.NamHoc.Visible = false;
            // 
            // ChuaHTHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 384);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grBoxThongTin);
            this.Controls.Add(this.panel1);
            this.Name = "ChuaHTHP";
            this.Text = "DSSV chưa hoàn thành HP";
            this.Load += new System.EventHandler(this.ChuaHTHP_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grBoxThongTin.ResumeLayout(false);
            this.grBoxThongTin.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuaHP)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox grBoxThongTin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_HocKy;
        private System.Windows.Forms.ComboBox comboBoxNamHoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvChuaHP;
        private System.Windows.Forms.Button btnTruyVan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienPhaiDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTienConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
    }
}