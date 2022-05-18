
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button_huy = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "HK1"});
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MaHK"});
            this.comboBox1.Location = new System.Drawing.Point(310, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 33);
            this.comboBox1.TabIndex = 11;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "HK1"});
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "MaMon",
            "IT001",
            "IT002",
            "SE334"});
            this.comboBox2.Location = new System.Drawing.Point(310, 244);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(165, 33);
            this.comboBox2.TabIndex = 12;
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
            // button_them
            // 
            this.button_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_them.AutoSize = true;
            this.button_them.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(489, 343);
            this.button_them.Margin = new System.Windows.Forms.Padding(0);
            this.button_them.MinimumSize = new System.Drawing.Size(180, 50);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(180, 50);
            this.button_them.TabIndex = 14;
            this.button_them.Text = "THÊM";
            this.button_them.UseVisualStyleBackColor = false;
            // 
            // MonHocMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.button_huy);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.Name = "MonHocMo";
            this.Text = "MonHocMo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.Button button_them;
    }
}