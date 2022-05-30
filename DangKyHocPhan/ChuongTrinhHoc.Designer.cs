namespace DangKyHocPhan
{
    partial class ChuongTrinhHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuongTrinhHoc));
            this.boxNganhHoc = new System.Windows.Forms.ComboBox();
            this.boxKhoa = new System.Windows.Forms.ComboBox();
            this.boxMonHoc = new System.Windows.Forms.ComboBox();
            this.button_luu = new System.Windows.Forms.Button();
            this.button_huy = new System.Windows.Forms.Button();
            this.txtHocKy = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // boxNganhHoc
            // 
            this.boxNganhHoc.AutoCompleteCustomSource.AddRange(new string[] {
            "HK1"});
            this.boxNganhHoc.DisplayMember = "MaHK";
            this.boxNganhHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNganhHoc.FormattingEnabled = true;
            this.boxNganhHoc.Location = new System.Drawing.Point(304, 157);
            this.boxNganhHoc.Name = "boxNganhHoc";
            this.boxNganhHoc.Size = new System.Drawing.Size(249, 33);
            this.boxNganhHoc.TabIndex = 12;
            this.boxNganhHoc.ValueMember = "HocKy";
            // 
            // boxKhoa
            // 
            this.boxKhoa.AutoCompleteCustomSource.AddRange(new string[] {
            "HK1"});
            this.boxKhoa.DisplayMember = "MaHK";
            this.boxKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxKhoa.FormattingEnabled = true;
            this.boxKhoa.Location = new System.Drawing.Point(304, 227);
            this.boxKhoa.Name = "boxKhoa";
            this.boxKhoa.Size = new System.Drawing.Size(249, 33);
            this.boxKhoa.TabIndex = 13;
            this.boxKhoa.ValueMember = "HocKy";
            // 
            // boxMonHoc
            // 
            this.boxMonHoc.AutoCompleteCustomSource.AddRange(new string[] {
            "HK1"});
            this.boxMonHoc.DisplayMember = "MaHK";
            this.boxMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMonHoc.FormattingEnabled = true;
            this.boxMonHoc.Location = new System.Drawing.Point(304, 354);
            this.boxMonHoc.Name = "boxMonHoc";
            this.boxMonHoc.Size = new System.Drawing.Size(249, 33);
            this.boxMonHoc.TabIndex = 15;
            this.boxMonHoc.ValueMember = "HocKy";
            // 
            // button_luu
            // 
            this.button_luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_luu.AutoSize = true;
            this.button_luu.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luu.Location = new System.Drawing.Point(599, 409);
            this.button_luu.Margin = new System.Windows.Forms.Padding(0);
            this.button_luu.MinimumSize = new System.Drawing.Size(180, 50);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(180, 50);
            this.button_luu.TabIndex = 16;
            this.button_luu.Text = "LƯU";
            this.button_luu.UseVisualStyleBackColor = false;
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // button_huy
            // 
            this.button_huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_huy.AutoSize = true;
            this.button_huy.BackColor = System.Drawing.SystemColors.Control;
            this.button_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_huy.Location = new System.Drawing.Point(403, 409);
            this.button_huy.Margin = new System.Windows.Forms.Padding(0);
            this.button_huy.MinimumSize = new System.Drawing.Size(180, 50);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(180, 50);
            this.button_huy.TabIndex = 17;
            this.button_huy.Text = "HỦY";
            this.button_huy.UseVisualStyleBackColor = false;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHocKy.Location = new System.Drawing.Point(304, 290);
            this.txtHocKy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(249, 34);
            this.txtHocKy.TabIndex = 18;
            // 
            // ChuongTrinhHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.txtHocKy);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.boxMonHoc);
            this.Controls.Add(this.boxKhoa);
            this.Controls.Add(this.boxNganhHoc);
            this.DoubleBuffered = true;
            this.Name = "ChuongTrinhHoc";
            this.Text = "ChuongTrinhHoc";
            this.Load += new System.EventHandler(this.ChuongTrinhHoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxNganhHoc;
        private System.Windows.Forms.ComboBox boxKhoa;
        private System.Windows.Forms.ComboBox boxMonHoc;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.TextBox txtHocKy;
    }
}