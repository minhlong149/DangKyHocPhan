
namespace DangKyHocPhan
{
    partial class DKHP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSMonDK = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSMonHocMo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnThuPhi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonDK)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHocMo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSMonDK);
            this.groupBox1.Location = new System.Drawing.Point(9, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(277, 263);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn học đã đăng ký";
            // 
            // dgvDSMonDK
            // 
            this.dgvDSMonDK.AllowUserToAddRows = false;
            this.dgvDSMonDK.AllowUserToDeleteRows = false;
            this.dgvDSMonDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonDK.Location = new System.Drawing.Point(4, 17);
            this.dgvDSMonDK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSMonDK.Name = "dgvDSMonDK";
            this.dgvDSMonDK.ReadOnly = true;
            this.dgvDSMonDK.RowHeadersWidth = 51;
            this.dgvDSMonDK.RowTemplate.Height = 24;
            this.dgvDSMonDK.Size = new System.Drawing.Size(268, 241);
            this.dgvDSMonDK.TabIndex = 0;
            this.dgvDSMonDK.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMonDK_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSMonHocMo);
            this.groupBox2.Location = new System.Drawing.Point(290, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(301, 346);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn học mở";
            // 
            // dgvDSMonHocMo
            // 
            this.dgvDSMonHocMo.AllowUserToAddRows = false;
            this.dgvDSMonHocMo.AllowUserToDeleteRows = false;
            this.dgvDSMonHocMo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonHocMo.Location = new System.Drawing.Point(4, 17);
            this.dgvDSMonHocMo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSMonHocMo.Name = "dgvDSMonHocMo";
            this.dgvDSMonHocMo.ReadOnly = true;
            this.dgvDSMonHocMo.RowHeadersWidth = 51;
            this.dgvDSMonHocMo.RowTemplate.Height = 24;
            this.dgvDSMonHocMo.Size = new System.Drawing.Size(292, 324);
            this.dgvDSMonHocMo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Học kỳ:";
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(57, 32);
            this.cboHocKy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(230, 21);
            this.cboHocKy.TabIndex = 3;
            this.cboHocKy.DropDownClosed += new System.EventHandler(this.cboHocKy_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "ĐĂNG KÝ HỌC PHẦN";
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(220, 324);
            this.btnThemMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(66, 32);
            this.btnThemMon.TabIndex = 5;
            this.btnThemMon.Text = "Thêm môn";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new System.Drawing.Point(149, 324);
            this.btnXoaMon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(66, 32);
            this.btnXoaMon.TabIndex = 6;
            this.btnXoaMon.Text = "Xóa môn";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(9, 324);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(66, 32);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Quay về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnThuPhi
            // 
            this.btnThuPhi.Location = new System.Drawing.Point(80, 324);
            this.btnThuPhi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThuPhi.Name = "btnThuPhi";
            this.btnThuPhi.Size = new System.Drawing.Size(65, 32);
            this.btnThuPhi.TabIndex = 8;
            this.btnThuPhi.Text = "Đóng tiền";
            this.btnThuPhi.UseVisualStyleBackColor = true;
            this.btnThuPhi.Click += new System.EventHandler(this.btnThuPhi_Click);
            // 
            // DKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnThuPhi);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DKHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DKHP";
            this.Load += new System.EventHandler(this.DKHP_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonDK)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHocMo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDSMonDK;
        private System.Windows.Forms.DataGridView dgvDSMonHocMo;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnThuPhi;
    }
}