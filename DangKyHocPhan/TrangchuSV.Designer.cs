
namespace DangKyHocPhan
{
    partial class TrangchuSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangchuSV));
            this.btnDKHP = new System.Windows.Forms.Button();
            this.btnXPTHP = new System.Windows.Forms.Button();
            this.btnThoatSV = new System.Windows.Forms.Button();
            this.btnDX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDKHP
            // 
            this.btnDKHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDKHP.Location = new System.Drawing.Point(124, 258);
            this.btnDKHP.Name = "btnDKHP";
            this.btnDKHP.Size = new System.Drawing.Size(260, 59);
            this.btnDKHP.TabIndex = 0;
            this.btnDKHP.Text = "Đăng Ký Học Phần";
            this.btnDKHP.UseVisualStyleBackColor = true;
            this.btnDKHP.Click += new System.EventHandler(this.btnDKHP_Click);
            // 
            // btnXPTHP
            // 
            this.btnXPTHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXPTHP.Location = new System.Drawing.Point(452, 258);
            this.btnXPTHP.Name = "btnXPTHP";
            this.btnXPTHP.Size = new System.Drawing.Size(283, 59);
            this.btnXPTHP.TabIndex = 1;
            this.btnXPTHP.Text = "Xuất Phiếu Thu Học Phí";
            this.btnXPTHP.UseVisualStyleBackColor = true;
            this.btnXPTHP.Click += new System.EventHandler(this.btnXPTHP_Click);
            // 
            // btnThoatSV
            // 
            this.btnThoatSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatSV.Location = new System.Drawing.Point(586, 360);
            this.btnThoatSV.Name = "btnThoatSV";
            this.btnThoatSV.Size = new System.Drawing.Size(149, 41);
            this.btnThoatSV.TabIndex = 2;
            this.btnThoatSV.Text = "Thoát";
            this.btnThoatSV.UseVisualStyleBackColor = true;
            this.btnThoatSV.Click += new System.EventHandler(this.btnThoatSV_Click);
            // 
            // btnDX
            // 
            this.btnDX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDX.Location = new System.Drawing.Point(414, 360);
            this.btnDX.Name = "btnDX";
            this.btnDX.Size = new System.Drawing.Size(149, 41);
            this.btnDX.TabIndex = 3;
            this.btnDX.Text = "Đăng xuất";
            this.btnDX.UseVisualStyleBackColor = true;
            this.btnDX.Click += new System.EventHandler(this.btnDX_Click);
            // 
            // TrangchuSV
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDX);
            this.Controls.Add(this.btnThoatSV);
            this.Controls.Add(this.btnXPTHP);
            this.Controls.Add(this.btnDKHP);
            this.DoubleBuffered = true;
            this.Name = "TrangchuSV";
            this.Text = "Trang Chủ Sinh Viên";
            this.Load += new System.EventHandler(this.TrangchuSV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDKHP;
        private System.Windows.Forms.Button btnXPTHP;
        private System.Windows.Forms.Button btnThoatSV;
        private System.Windows.Forms.Button btnDX;
    }
}
