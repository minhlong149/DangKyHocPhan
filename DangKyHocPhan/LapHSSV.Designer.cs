
namespace DangKyHocPhan
{
    partial class LapHSSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapHSSV));
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.pickNS = new System.Windows.Forms.DateTimePicker();
            this.CBoxTinh = new System.Windows.Forms.ComboBox();
            this.tINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKHPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKHPDataSet = new DangKyHocPhan.DKHPDataSet();
            this.CBoxDT = new System.Windows.Forms.ComboBox();
            this.dOITUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLHS = new System.Windows.Forms.Button();
            this.btnThoatLHS = new System.Windows.Forms.Button();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.CBoxHuyen = new System.Windows.Forms.ComboBox();
            this.CBoxNganh = new System.Windows.Forms.ComboBox();
            this.nGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tINHTableAdapter = new DangKyHocPhan.DKHPDataSetTableAdapters.TINHTableAdapter();
            this.dOITUONGTableAdapter = new DangKyHocPhan.DKHPDataSetTableAdapters.DOITUONGTableAdapter();
            this.nGANHTableAdapter = new DangKyHocPhan.DKHPDataSetTableAdapters.NGANHTableAdapter();
            this.dOITUONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITUONGBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(304, 303);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(207, 26);
            this.txtMSSV.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(304, 354);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(207, 26);
            this.txtHoTen.TabIndex = 1;
            // 
            // pickNS
            // 
            this.pickNS.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickNS.CustomFormat = "dd/MM/yyyy";
            this.pickNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickNS.Location = new System.Drawing.Point(373, 461);
            this.pickNS.Name = "pickNS";
            this.pickNS.Size = new System.Drawing.Size(138, 26);
            this.pickNS.TabIndex = 10;
            this.pickNS.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // CBoxTinh
            // 
            this.CBoxTinh.DataSource = this.tINHBindingSource;
            this.CBoxTinh.DisplayMember = "TenTinh";
            this.CBoxTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxTinh.FormattingEnabled = true;
            this.CBoxTinh.Location = new System.Drawing.Point(373, 572);
            this.CBoxTinh.Name = "CBoxTinh";
            this.CBoxTinh.Size = new System.Drawing.Size(138, 28);
            this.CBoxTinh.TabIndex = 11;
            this.CBoxTinh.SelectedIndexChanged += new System.EventHandler(this.CBoxTinh_SelectedIndexChanged);
            // 
            // tINHBindingSource
            // 
            this.tINHBindingSource.DataMember = "TINH";
            this.tINHBindingSource.DataSource = this.dKHPDataSetBindingSource;
            // 
            // dKHPDataSetBindingSource
            // 
            this.dKHPDataSetBindingSource.DataSource = this.dKHPDataSet;
            this.dKHPDataSetBindingSource.Position = 0;
            // 
            // dKHPDataSet
            // 
            this.dKHPDataSet.DataSetName = "DKHPDataSet";
            this.dKHPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CBoxDT
            // 
            this.CBoxDT.DataSource = this.dOITUONGBindingSource1;
            this.CBoxDT.DisplayMember = "TenDT";
            this.CBoxDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxDT.FormattingEnabled = true;
            this.CBoxDT.Location = new System.Drawing.Point(304, 520);
            this.CBoxDT.Name = "CBoxDT";
            this.CBoxDT.Size = new System.Drawing.Size(207, 28);
            this.CBoxDT.TabIndex = 13;
            // 
            // dOITUONGBindingSource
            // 
            this.dOITUONGBindingSource.DataMember = "DOITUONG";
            this.dOITUONGBindingSource.DataSource = this.dKHPDataSetBindingSource;
            // 
            // btnLHS
            // 
            this.btnLHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLHS.Location = new System.Drawing.Point(78, 720);
            this.btnLHS.Name = "btnLHS";
            this.btnLHS.Size = new System.Drawing.Size(153, 29);
            this.btnLHS.TabIndex = 17;
            this.btnLHS.Text = "Lưu hồ sơ";
            this.btnLHS.UseVisualStyleBackColor = true;
            this.btnLHS.Click += new System.EventHandler(this.btnLHS_Click);
            // 
            // btnThoatLHS
            // 
            this.btnThoatLHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatLHS.Location = new System.Drawing.Point(358, 720);
            this.btnThoatLHS.Name = "btnThoatLHS";
            this.btnThoatLHS.Size = new System.Drawing.Size(153, 29);
            this.btnThoatLHS.TabIndex = 18;
            this.btnThoatLHS.Text = "Thoát";
            this.btnThoatLHS.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNam.Location = new System.Drawing.Point(304, 404);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(60, 24);
            this.rbtnNam.TabIndex = 15;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = false;
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rbtnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNu.Location = new System.Drawing.Point(400, 404);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(47, 24);
            this.rbtnNu.TabIndex = 16;
            this.rbtnNu.TabStop = true;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = false;
            // 
            // CBoxHuyen
            // 
            this.CBoxHuyen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tINHBindingSource, "MaTinh", true));
            this.CBoxHuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxHuyen.Items.AddRange(new object[] {
            "None"});
            this.CBoxHuyen.Location = new System.Drawing.Point(163, 572);
            this.CBoxHuyen.Name = "CBoxHuyen";
            this.CBoxHuyen.Size = new System.Drawing.Size(138, 28);
            this.CBoxHuyen.TabIndex = 19;
            // 
            // CBoxNganh
            // 
            this.CBoxNganh.DataSource = this.nGANHBindingSource;
            this.CBoxNganh.DisplayMember = "TenNganh";
            this.CBoxNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxNganh.FormattingEnabled = true;
            this.CBoxNganh.Location = new System.Drawing.Point(243, 623);
            this.CBoxNganh.Name = "CBoxNganh";
            this.CBoxNganh.Size = new System.Drawing.Size(268, 28);
            this.CBoxNganh.TabIndex = 14;
            // 
            // nGANHBindingSource
            // 
            this.nGANHBindingSource.DataMember = "NGANH";
            this.nGANHBindingSource.DataSource = this.dKHPDataSetBindingSource;
            // 
            // tINHTableAdapter
            // 
            this.tINHTableAdapter.ClearBeforeFill = true;
            // 
            // dOITUONGTableAdapter
            // 
            this.dOITUONGTableAdapter.ClearBeforeFill = true;
            // 
            // nGANHTableAdapter
            // 
            this.nGANHTableAdapter.ClearBeforeFill = true;
            // 
            // dOITUONGBindingSource1
            // 
            this.dOITUONGBindingSource1.DataMember = "DOITUONG";
            this.dOITUONGBindingSource1.DataSource = this.dKHPDataSetBindingSource;
            // 
            // LapHSSV
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(589, 812);
            this.Controls.Add(this.CBoxHuyen);
            this.Controls.Add(this.btnThoatLHS);
            this.Controls.Add(this.btnLHS);
            this.Controls.Add(this.rbtnNu);
            this.Controls.Add(this.rbtnNam);
            this.Controls.Add(this.CBoxNganh);
            this.Controls.Add(this.CBoxDT);
            this.Controls.Add(this.CBoxTinh);
            this.Controls.Add(this.pickNS);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMSSV);
            this.DoubleBuffered = true;
            this.Name = "LapHSSV";
            this.Text = "Lập Hồ Sơ Sinh Viên";
            this.Load += new System.EventHandler(this.LapHSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITUONGBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker pickNS;
        private System.Windows.Forms.ComboBox CBoxTinh;
        private System.Windows.Forms.ComboBox CBoxDT;
        private System.Windows.Forms.Button btnLHS;
        private System.Windows.Forms.Button btnThoatLHS;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.ComboBox CBoxHuyen;
        private System.Windows.Forms.ComboBox CBoxNganh;
        private DKHPDataSet dKHPDataSet;
        private System.Windows.Forms.BindingSource dKHPDataSetBindingSource;
        private System.Windows.Forms.BindingSource tINHBindingSource;
        private DKHPDataSetTableAdapters.TINHTableAdapter tINHTableAdapter;
        private System.Windows.Forms.BindingSource dOITUONGBindingSource;
        private DKHPDataSetTableAdapters.DOITUONGTableAdapter dOITUONGTableAdapter;
        private System.Windows.Forms.BindingSource nGANHBindingSource;
        private DKHPDataSetTableAdapters.NGANHTableAdapter nGANHTableAdapter;
        private System.Windows.Forms.BindingSource dOITUONGBindingSource1;
    }
}
