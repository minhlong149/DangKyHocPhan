
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
            this.groupBox1.Location = new System.Drawing.Point(12, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 324);
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
            this.dgvDSMonDK.Size = new System.Drawing.Size(357, 297);
            this.dgvDSMonDK.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSMonHocMo);
            this.groupBox2.Location = new System.Drawing.Point(387, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 426);
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
            this.dgvDSMonHocMo.Size = new System.Drawing.Size(389, 399);
            this.dgvDSMonHocMo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Học kỳ:";
            // 
            // cboHocKy
            // 
            this.cboHocKy.FormattingEnabled = true;
            this.cboHocKy.Location = new System.Drawing.Point(76, 39);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(305, 24);
            this.cboHocKy.TabIndex = 3;
            this.cboHocKy.DropDownClosed += new System.EventHandler(this.cboHocKy_DropDownClosed);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 9);
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 399);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 39);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Quay về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // DKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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