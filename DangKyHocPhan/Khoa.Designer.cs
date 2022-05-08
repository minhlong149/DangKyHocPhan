
namespace DangKyHocPhan
{
    partial class Khoa
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
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.btnSuaKhoa = new System.Windows.Forms.Button();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDSKhoa = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(7, 29);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(66, 17);
            this.lblMaKhoa.TabIndex = 1;
            this.lblMaKhoa.Text = "Mã khoa:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(79, 29);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(156, 22);
            this.txtMaKhoa.TabIndex = 2;
            this.txtMaKhoa.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(79, 57);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(156, 22);
            this.txtTenKhoa.TabIndex = 4;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(7, 57);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(72, 17);
            this.lblTenKhoa.TabIndex = 3;
            this.lblTenKhoa.Text = "Tên khoa:";
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Location = new System.Drawing.Point(166, 95);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(69, 23);
            this.btnThemKhoa.TabIndex = 5;
            this.btnThemKhoa.Text = "Thêm";
            this.btnThemKhoa.UseVisualStyleBackColor = true;
            this.btnThemKhoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Location = new System.Drawing.Point(91, 95);
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.Size = new System.Drawing.Size(69, 23);
            this.btnSuaKhoa.TabIndex = 6;
            this.btnSuaKhoa.Text = "Sửa";
            this.btnSuaKhoa.UseVisualStyleBackColor = true;
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Location = new System.Drawing.Point(16, 95);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(69, 23);
            this.btnXoaKhoa.TabIndex = 7;
            this.btnXoaKhoa.Text = "Xóa";
            this.btnXoaKhoa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(this.btnSuaKhoa);
            this.groupBox1.Controls.Add(this.btnXoaKhoa);
            this.groupBox1.Controls.Add(this.lblMaKhoa);
            this.groupBox1.Controls.Add(this.lblTenKhoa);
            this.groupBox1.Controls.Add(this.btnThemKhoa);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 129);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý khoa";
            // 
            // lvDSKhoa
            // 
            this.lvDSKhoa.HideSelection = false;
            this.lvDSKhoa.Location = new System.Drawing.Point(262, 12);
            this.lvDSKhoa.Name = "lvDSKhoa";
            this.lvDSKhoa.Size = new System.Drawing.Size(508, 429);
            this.lvDSKhoa.TabIndex = 8;
            this.lvDSKhoa.UseCompatibleStateImageBehavior = false;
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lvDSKhoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "Khoa";
            this.Text = "KhoaNganh";
            this.Load += new System.EventHandler(this.Khoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.Button btnThemKhoa;
        private System.Windows.Forms.Button btnSuaKhoa;
        private System.Windows.Forms.Button btnXoaKhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvDSKhoa;
    }
}