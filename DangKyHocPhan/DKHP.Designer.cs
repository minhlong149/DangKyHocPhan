
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
            this.btnThuPhi = new System.Windows.Forms.Button();
            this.txtTinChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgayLap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonDK)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMonHocMo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTinChi);
            this.groupBox1.Controls.Add(this.dgvDSMonDK);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 323);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Môn học đã đăng ký";
            // 
            // dgvDSMonDK
            // 
            this.dgvDSMonDK.AllowUserToAddRows = false;
            this.dgvDSMonDK.AllowUserToDeleteRows = false;
            this.dgvDSMonDK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonDK.Location = new System.Drawing.Point(6, 21);
            this.dgvDSMonDK.Name = "dgvDSMonDK";
            this.dgvDSMonDK.ReadOnly = true;
            this.dgvDSMonDK.RowHeadersWidth = 51;
            this.dgvDSMonDK.RowTemplate.Height = 24;
            this.dgvDSMonDK.Size = new System.Drawing.Size(357, 269);
            this.dgvDSMonDK.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSMonHocMo);
            this.groupBox2.Location = new System.Drawing.Point(387, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 368);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách môn học mở";
            // 
            // dgvDSMonHocMo
            // 
            this.dgvDSMonHocMo.AllowUserToAddRows = false;
            this.dgvDSMonHocMo.AllowUserToDeleteRows = false;
            this.dgvDSMonHocMo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMonHocMo.Location = new System.Drawing.Point(6, 21);
            this.dgvDSMonHocMo.Name = "dgvDSMonHocMo";
            this.dgvDSMonHocMo.ReadOnly = true;
            this.dgvDSMonHocMo.RowHeadersWidth = 51;
            this.dgvDSMonHocMo.RowTemplate.Height = 24;
            this.dgvDSMonHocMo.Size = new System.Drawing.Size(389, 342);
            this.dgvDSMonHocMo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Học kỳ:";
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(464, 12);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(318, 24);
            this.cboHocKy.TabIndex = 3;
            this.cboHocKy.DropDownClosed += new System.EventHandler(this.cboHocKy_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "ĐĂNG KÝ HỌC PHẦN";
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(293, 399);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(88, 39);
            this.btnThemMon.TabIndex = 5;
            this.btnThemMon.Text = "Thêm môn";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.Location = new System.Drawing.Point(199, 399);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(88, 39);
            this.btnXoaMon.TabIndex = 6;
            this.btnXoaMon.Text = "Xóa môn";
            this.btnXoaMon.UseVisualStyleBackColor = true;
            this.btnXoaMon.Click += new System.EventHandler(this.btnXoaMon_Click);
            // 
            // btnThuPhi
            // 
            this.btnThuPhi.Location = new System.Drawing.Point(106, 399);
            this.btnThuPhi.Name = "btnThuPhi";
            this.btnThuPhi.Size = new System.Drawing.Size(87, 39);
            this.btnThuPhi.TabIndex = 8;
            this.btnThuPhi.Text = "Đóng tiền";
            this.btnThuPhi.UseVisualStyleBackColor = true;
            this.btnThuPhi.Click += new System.EventHandler(this.btnThuPhi_Click);
            // 
            // txtTinChi
            // 
            this.txtTinChi.Location = new System.Drawing.Point(293, 296);
            this.txtTinChi.Name = "txtTinChi";
            this.txtTinChi.ReadOnly = true;
            this.txtTinChi.Size = new System.Drawing.Size(70, 22);
            this.txtTinChi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng số tín chỉ đăng ký:";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(112, 42);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.ReadOnly = true;
            this.txtMSSV.Size = new System.Drawing.Size(269, 22);
            this.txtMSSV.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mã sinh viên:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.Location = new System.Drawing.Point(464, 42);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.ReadOnly = true;
            this.txtSoPhieu.Size = new System.Drawing.Size(126, 22);
            this.txtSoPhieu.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(390, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Số phiếu:";
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.Location = new System.Drawing.Point(666, 42);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.ReadOnly = true;
            this.txtNgayLap.Size = new System.Drawing.Size(116, 22);
            this.txtNgayLap.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(596, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ngày lập";
            // 
            // DKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.txtSoPhieu);
            this.Controls.Add(this.btnThuPhi);
            this.Controls.Add(this.btnXoaMon);
            this.Controls.Add(this.btnThemMon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "DKHP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DKHP";
            this.Load += new System.EventHandler(this.DKHP_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnThuPhi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTinChi;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNgayLap;
        private System.Windows.Forms.Label label6;
    }
}