
namespace DangKyHocPhan
{
    partial class MonHocMo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHocMo));
            this.txtMaHocKy = new System.Windows.Forms.ComboBox();
            this.txtMaMonHoc = new System.Windows.Forms.ComboBox();
            this.button_huy = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMaHocKy
            // 
            this.txtMaHocKy.AutoCompleteCustomSource.AddRange(new string[] {
            "HK1"});
            this.txtMaHocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHocKy.FormattingEnabled = true;
            this.txtMaHocKy.Items.AddRange(new object[] {
            "MaHK"});
            this.txtMaHocKy.Location = new System.Drawing.Point(310, 156);
            this.txtMaHocKy.Name = "txtMaHocKy";
            this.txtMaHocKy.Size = new System.Drawing.Size(165, 33);
            this.txtMaHocKy.TabIndex = 11;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.AutoCompleteCustomSource.AddRange(new string[] {
            "HK1"});
            this.txtMaMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMonHoc.FormattingEnabled = true;
            this.txtMaMonHoc.Items.AddRange(new object[] {
            "MaMon",
            "IT001",
            "IT002",
            "SE334"});
            this.txtMaMonHoc.Location = new System.Drawing.Point(310, 244);
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Size = new System.Drawing.Size(165, 33);
            this.txtMaMonHoc.TabIndex = 12;
            // 
            // button_huy
            // 
            this.button_huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_huy.AutoSize = true;
            this.button_huy.BackColor = System.Drawing.SystemColors.Control;
            this.button_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_huy.Location = new System.Drawing.Point(84, 343);
            this.button_huy.Margin = new System.Windows.Forms.Padding(0);
            this.button_huy.MinimumSize = new System.Drawing.Size(180, 50);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(180, 50);
            this.button_huy.TabIndex = 13;
            this.button_huy.Text = "HỦY";
            this.button_huy.UseVisualStyleBackColor = false;
            // 
            // button_luu
            // 
            this.button_luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_luu.AutoSize = true;
            this.button_luu.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luu.Location = new System.Drawing.Point(489, 343);
            this.button_luu.Margin = new System.Windows.Forms.Padding(0);
            this.button_luu.MinimumSize = new System.Drawing.Size(180, 50);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(180, 50);
            this.button_luu.TabIndex = 14;
            this.button_luu.Text = "LƯU";
            this.button_luu.UseVisualStyleBackColor = false;
            // 
            // MonHocMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.txtMaMonHoc);
            this.Controls.Add(this.txtMaHocKy);
            this.DoubleBuffered = true;
            this.Name = "MonHocMo";
            this.Text = "MonHocMo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtMaHocKy;
        private System.Windows.Forms.ComboBox txtMaMonHoc;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.Button button_luu;
    }
}