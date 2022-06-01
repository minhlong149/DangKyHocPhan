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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(837, 63);
            this.panel1.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(56, 23);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(637, 24);
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
            this.grBoxThongTin.Location = new System.Drawing.Point(0, 63);
            this.grBoxThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grBoxThongTin.Name = "grBoxThongTin";
            this.grBoxThongTin.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grBoxThongTin.Size = new System.Drawing.Size(837, 92);
            this.grBoxThongTin.TabIndex = 1;
            this.grBoxThongTin.TabStop = false;
            this.grBoxThongTin.Text = "Thông tin năm học";
            this.grBoxThongTin.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxNamHoc
            // 
            this.comboBoxNamHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNamHoc.FormattingEnabled = true;
            this.comboBoxNamHoc.Location = new System.Drawing.Point(132, 58);
            this.comboBoxNamHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxNamHoc.Name = "comboBoxNamHoc";
            this.comboBoxNamHoc.Size = new System.Drawing.Size(156, 32);
            this.comboBoxNamHoc.TabIndex = 3;
            // 
            // btnTruyVan
            // 
            this.btnTruyVan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnTruyVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTruyVan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTruyVan.Location = new System.Drawing.Point(707, 47);
            this.btnTruyVan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTruyVan.Name = "btnTruyVan";
            this.btnTruyVan.Size = new System.Drawing.Size(100, 43);
            this.btnTruyVan.TabIndex = 4;
            this.btnTruyVan.Text = "Tìm";
            this.btnTruyVan.UseVisualStyleBackColor = false;
            this.btnTruyVan.Click += new System.EventHandler(this.btnTruyVan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
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
            this.comboBox_HocKy.Location = new System.Drawing.Point(132, 22);
            this.comboBox_HocKy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_HocKy.Name = "comboBox_HocKy";
            this.comboBox_HocKy.Size = new System.Drawing.Size(156, 32);
            this.comboBox_HocKy.TabIndex = 1;
            this.comboBox_HocKy.SelectedIndexChanged += new System.EventHandler(this.comboBox_HocKy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học kỳ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnThoat.Location = new System.Drawing.Point(706, 4);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 42);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvChuaHP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 155);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 264);
            this.panel2.TabIndex = 3;
            // 
            // dgvChuaHP
            // 
            this.dgvChuaHP.AllowUserToAddRows = false;
            this.dgvChuaHP.AllowUserToDeleteRows = false;
            this.dgvChuaHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuaHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChuaHP.Location = new System.Drawing.Point(0, 0);
            this.dgvChuaHP.Margin = new System.Windows.Forms.Padding(133, 123, 133, 123);
            this.dgvChuaHP.Name = "dgvChuaHP";
            this.dgvChuaHP.ReadOnly = true;
            this.dgvChuaHP.RowHeadersWidth = 51;
            this.dgvChuaHP.Size = new System.Drawing.Size(837, 264);
            this.dgvChuaHP.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnThoat);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 419);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(837, 54);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // ChuaHTHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 473);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grBoxThongTin);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}