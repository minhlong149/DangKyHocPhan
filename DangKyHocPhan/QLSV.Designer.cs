
namespace DangKyHocPhan
{
    partial class QLSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.pickNS = new System.Windows.Forms.DateTimePicker();
            this.CBoxTinh = new System.Windows.Forms.ComboBox();
            this.tINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKHPDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKHPDataSet = new DangKyHocPhan.DKHPDataSet();
            this.CBoxDT = new System.Windows.Forms.ComboBox();
            this.dOITUONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dOITUONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.CBoxHuyen = new System.Windows.Forms.ComboBox();
            this.CBoxNganh = new System.Windows.Forms.ComboBox();
            this.nGANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tINHTableAdapter = new DangKyHocPhan.DKHPDataSetTableAdapters.TINHTableAdapter();
            this.dOITUONGTableAdapter = new DangKyHocPhan.DKHPDataSetTableAdapters.DOITUONGTableAdapter();
            this.nGANHTableAdapter = new DangKyHocPhan.DKHPDataSetTableAdapters.NGANHTableAdapter();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnXoaHS = new System.Windows.Forms.Button();
            this.btnThoatLHS = new System.Windows.Forms.Button();
            this.btnLHS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tINHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITUONGBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITUONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMSSV
            // 
            this.txtMSSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMSSV.Location = new System.Drawing.Point(201, 131);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(186, 26);
            this.txtMSSV.TabIndex = 0;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(201, 185);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(186, 26);
            this.txtHoTen.TabIndex = 1;
            // 
            // pickNS
            // 
            this.pickNS.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickNS.CustomFormat = "dd/MM/yyyy";
            this.pickNS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickNS.Location = new System.Drawing.Point(201, 277);
            this.pickNS.Name = "pickNS";
            this.pickNS.Size = new System.Drawing.Size(138, 26);
            this.pickNS.TabIndex = 10;
            // 
            // CBoxTinh
            // 
            this.CBoxTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxTinh.FormattingEnabled = true;
            this.CBoxTinh.Location = new System.Drawing.Point(273, 374);
            this.CBoxTinh.Name = "CBoxTinh";
            this.CBoxTinh.Size = new System.Drawing.Size(114, 28);
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
            this.CBoxDT.Location = new System.Drawing.Point(201, 323);
            this.CBoxDT.Name = "CBoxDT";
            this.CBoxDT.Size = new System.Drawing.Size(186, 28);
            this.CBoxDT.TabIndex = 13;
            this.CBoxDT.ValueMember = "MaDT";
            // 
            // dOITUONGBindingSource1
            // 
            this.dOITUONGBindingSource1.DataMember = "DOITUONG";
            this.dOITUONGBindingSource1.DataSource = this.dKHPDataSetBindingSource;
            // 
            // dOITUONGBindingSource
            // 
            this.dOITUONGBindingSource.DataMember = "DOITUONG";
            this.dOITUONGBindingSource.DataSource = this.dKHPDataSetBindingSource;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.BackColor = System.Drawing.SystemColors.Control;
            this.rbtnNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNam.Location = new System.Drawing.Point(201, 232);
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
            this.rbtnNu.BackColor = System.Drawing.SystemColors.Control;
            this.rbtnNu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNu.Location = new System.Drawing.Point(292, 232);
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
            this.CBoxHuyen.Location = new System.Drawing.Point(100, 374);
            this.CBoxHuyen.Name = "CBoxHuyen";
            this.CBoxHuyen.Size = new System.Drawing.Size(119, 28);
            this.CBoxHuyen.TabIndex = 19;
            // 
            // CBoxNganh
            // 
            this.CBoxNganh.DataSource = this.nGANHBindingSource;
            this.CBoxNganh.DisplayMember = "TenNganh";
            this.CBoxNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxNganh.FormattingEnabled = true;
            this.CBoxNganh.Location = new System.Drawing.Point(160, 428);
            this.CBoxNganh.Name = "CBoxNganh";
            this.CBoxNganh.Size = new System.Drawing.Size(227, 28);
            this.CBoxNganh.TabIndex = 14;
            this.CBoxNganh.ValueMember = "MaNganh";
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
            // dgvSV
            // 
            this.dgvSV.AllowUserToAddRows = false;
            this.dgvSV.AllowUserToDeleteRows = false;
            this.dgvSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSV.Location = new System.Drawing.Point(409, 84);
            this.dgvSV.Margin = new System.Windows.Forms.Padding(5);
            this.dgvSV.MultiSelect = false;
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSV.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSV.RowTemplate.Height = 40;
            this.dgvSV.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSV.Size = new System.Drawing.Size(1051, 472);
            this.dgvSV.TabIndex = 0;
            this.dgvSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSV_CellContentClick);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(1345, 41);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(97, 29);
            this.btnTimkiem.TabIndex = 20;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Mã số sinh viên";
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(1164, 41);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(175, 26);
            this.txtTukhoa.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Họ và tên sinh viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Giới tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Đối tượng miễn giảm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Huyện";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(227, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tỉnh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Ngành học";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1092, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "Từ khoá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(405, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(208, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "DANH SÁCH SINH VIÊN";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(146, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 20);
            this.label11.TabIndex = 32;
            this.label11.Text = "HỒ SƠ SINH VIÊN";
            // 
            // btnXoaHS
            // 
            this.btnXoaHS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoaHS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoaHS.Location = new System.Drawing.Point(166, 501);
            this.btnXoaHS.Name = "btnXoaHS";
            this.btnXoaHS.Size = new System.Drawing.Size(95, 29);
            this.btnXoaHS.TabIndex = 33;
            this.btnXoaHS.Text = "Xoá";
            this.btnXoaHS.UseVisualStyleBackColor = false;
            this.btnXoaHS.Click += new System.EventHandler(this.btnXoaHS_Click);
            // 
            // btnThoatLHS
            // 
            this.btnThoatLHS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoatLHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoatLHS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoatLHS.Location = new System.Drawing.Point(292, 501);
            this.btnThoatLHS.Name = "btnThoatLHS";
            this.btnThoatLHS.Size = new System.Drawing.Size(95, 29);
            this.btnThoatLHS.TabIndex = 18;
            this.btnThoatLHS.Text = "Thoát";
            this.btnThoatLHS.UseVisualStyleBackColor = false;
            this.btnThoatLHS.Click += new System.EventHandler(this.btnThoatLHS_Click);
            // 
            // btnLHS
            // 
            this.btnLHS.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLHS.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLHS.Location = new System.Drawing.Point(43, 501);
            this.btnLHS.Name = "btnLHS";
            this.btnLHS.Size = new System.Drawing.Size(95, 29);
            this.btnLHS.TabIndex = 17;
            this.btnLHS.Text = "Lưu hồ sơ";
            this.btnLHS.UseVisualStyleBackColor = false;
            this.btnLHS.Click += new System.EventHandler(this.btnLHS_Click);
            // 
            // QLSV
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1472, 568);
            this.Controls.Add(this.btnXoaHS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.dgvSV);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1488, 607);
            this.MinimumSize = new System.Drawing.Size(1488, 607);
            this.Name = "QLSV";
            this.Text = "Lập Hồ Sơ Sinh Viên";
            this.Load += new System.EventHandler(this.LapHSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tINHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITUONGBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOITUONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker pickNS;
        private System.Windows.Forms.ComboBox CBoxTinh;
        private System.Windows.Forms.ComboBox CBoxDT;
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
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXoaHS;
        private System.Windows.Forms.Button btnThoatLHS;
        private System.Windows.Forms.Button btnLHS;
    }
}
