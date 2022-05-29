
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHocMo));
            this.boxMaHK = new System.Windows.Forms.ComboBox();
            this.dSHOCKYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKHPDataSet = new DangKyHocPhan.DKHPDataSet();
            this.boxMaMH = new System.Windows.Forms.ComboBox();
            this.button_huy = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.dSHOCKYTableAdapter = new DangKyHocPhan.DKHPDataSetTableAdapters.DSHOCKYTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSHOCKYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // boxMaHK
            // 
            this.boxMaHK.AutoCompleteCustomSource.AddRange(new string[] {
            "HK1"});
            this.boxMaHK.DataSource = this.dSHOCKYBindingSource;
            this.boxMaHK.DisplayMember = "MaHK";
            this.boxMaHK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMaHK.FormattingEnabled = true;
            this.boxMaHK.Location = new System.Drawing.Point(310, 156);
            this.boxMaHK.Name = "boxMaHK";
            this.boxMaHK.Size = new System.Drawing.Size(249, 33);
            this.boxMaHK.TabIndex = 11;
            this.boxMaHK.ValueMember = "HocKy";
            this.boxMaHK.SelectedIndexChanged += new System.EventHandler(this.boxMaHocKy_SelectedIndexChanged);
            // 
            // dSHOCKYBindingSource
            // 
            this.dSHOCKYBindingSource.DataMember = "DSHOCKY";
            this.dSHOCKYBindingSource.DataSource = this.dKHPDataSet;
            // 
            // dKHPDataSet
            // 
            this.dKHPDataSet.DataSetName = "DKHPDataSet";
            this.dKHPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boxMaMH
            // 
            this.boxMaMH.AutoCompleteCustomSource.AddRange(new string[] {
            "HK1"});
            this.boxMaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMaMH.FormattingEnabled = true;
            this.boxMaMH.Items.AddRange(new object[] {
            "MaMon",
            "IT001",
            "IT002",
            "SE334"});
            this.boxMaMH.Location = new System.Drawing.Point(310, 244);
            this.boxMaMH.Name = "boxMaMH";
            this.boxMaMH.Size = new System.Drawing.Size(249, 33);
            this.boxMaMH.TabIndex = 12;
            // 
            // button_huy
            // 
            this.button_huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_huy.AutoSize = true;
            this.button_huy.BackColor = System.Drawing.SystemColors.Control;
            this.button_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huy.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_huy.Location = new System.Drawing.Point(100, 343);
            this.button_huy.Margin = new System.Windows.Forms.Padding(0);
            this.button_huy.MinimumSize = new System.Drawing.Size(180, 50);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(180, 50);
            this.button_huy.TabIndex = 13;
            this.button_huy.Text = "HỦY";
            this.button_huy.UseVisualStyleBackColor = false;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // button_luu
            // 
            this.button_luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button_luu.AutoSize = true;
            this.button_luu.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luu.Location = new System.Drawing.Point(466, 343);
            this.button_luu.Margin = new System.Windows.Forms.Padding(0);
            this.button_luu.MinimumSize = new System.Drawing.Size(180, 50);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(180, 50);
            this.button_luu.TabIndex = 14;
            this.button_luu.Text = "LƯU";
            this.button_luu.UseVisualStyleBackColor = false;
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // dSHOCKYTableAdapter
            // 
            this.dSHOCKYTableAdapter.ClearBeforeFill = true;
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
            this.Controls.Add(this.boxMaMH);
            this.Controls.Add(this.boxMaHK);
            this.DoubleBuffered = true;
            this.Name = "MonHocMo";
            this.Text = "MonHocMo";
            this.Load += new System.EventHandler(this.MonHocMo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dSHOCKYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxMaHK;
        private System.Windows.Forms.ComboBox boxMaMH;
        private System.Windows.Forms.Button button_huy;
        private System.Windows.Forms.Button button_luu;
        private DKHPDataSet dKHPDataSet;
        private System.Windows.Forms.BindingSource dSHOCKYBindingSource;
        private DKHPDataSetTableAdapters.DSHOCKYTableAdapter dSHOCKYTableAdapter;
    }
}