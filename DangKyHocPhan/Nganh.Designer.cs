
namespace DangKyHocPhan
{
    partial class Nganh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboThuocKhoa = new System.Windows.Forms.ComboBox();
            this.lblThuocKhoa = new System.Windows.Forms.Label();
            this.txtMaNganh = new System.Windows.Forms.TextBox();
            this.btnThemNganh = new System.Windows.Forms.Button();
            this.lblMaNganh = new System.Windows.Forms.Label();
            this.btnSuaNganh = new System.Windows.Forms.Button();
            this.lblTenNganh = new System.Windows.Forms.Label();
            this.btnXoaNganh = new System.Windows.Forms.Button();
            this.txtTenNganh = new System.Windows.Forms.TextBox();
            this.dKHPDataSet = new DangKyHocPhan.DKHPDataSet();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHOATableAdapter = new DangKyHocPhan.DKHPDataSetTableAdapters.KHOATableAdapter();
            this.dgvDSNganh = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNganh)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboThuocKhoa);
            this.groupBox1.Controls.Add(this.lblThuocKhoa);
            this.groupBox1.Controls.Add(this.txtMaNganh);
            this.groupBox1.Controls.Add(this.btnThemNganh);
            this.groupBox1.Controls.Add(this.lblMaNganh);
            this.groupBox1.Controls.Add(this.btnSuaNganh);
            this.groupBox1.Controls.Add(this.lblTenNganh);
            this.groupBox1.Controls.Add(this.btnXoaNganh);
            this.groupBox1.Controls.Add(this.txtTenNganh);
            this.groupBox1.Location = new System.Drawing.Point(376, 225);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(214, 131);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ngành đào tạo";
            // 
            // cboThuocKhoa
            // 
            this.cboThuocKhoa.FormattingEnabled = true;
            this.cboThuocKhoa.Location = new System.Drawing.Point(77, 70);
            this.cboThuocKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboThuocKhoa.Name = "cboThuocKhoa";
            this.cboThuocKhoa.Size = new System.Drawing.Size(134, 21);
            this.cboThuocKhoa.TabIndex = 4;
            this.cboThuocKhoa.SelectedValueChanged += new System.EventHandler(this.cboThuocKhoa_SelectedIndexChanged);
            // 
            // lblThuocKhoa
            // 
            this.lblThuocKhoa.AutoSize = true;
            this.lblThuocKhoa.Location = new System.Drawing.Point(8, 72);
            this.lblThuocKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblThuocKhoa.Name = "lblThuocKhoa";
            this.lblThuocKhoa.Size = new System.Drawing.Size(68, 13);
            this.lblThuocKhoa.TabIndex = 10;
            this.lblThuocKhoa.Text = "Thuộc khoa:";
            // 
            // txtMaNganh
            // 
            this.txtMaNganh.Location = new System.Drawing.Point(77, 24);
            this.txtMaNganh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNganh.Name = "txtMaNganh";
            this.txtMaNganh.Size = new System.Drawing.Size(134, 20);
            this.txtMaNganh.TabIndex = 2;
            this.txtMaNganh.TextChanged += new System.EventHandler(this.txtMaNganh_TextChanged);
            // 
            // btnThemNganh
            // 
            this.btnThemNganh.Location = new System.Drawing.Point(158, 100);
            this.btnThemNganh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemNganh.Name = "btnThemNganh";
            this.btnThemNganh.Size = new System.Drawing.Size(52, 19);
            this.btnThemNganh.TabIndex = 5;
            this.btnThemNganh.Text = "Thêm";
            this.btnThemNganh.UseVisualStyleBackColor = true;
            this.btnThemNganh.Click += new System.EventHandler(this.btnThemNganh_Click);
            // 
            // lblMaNganh
            // 
            this.lblMaNganh.AutoSize = true;
            this.lblMaNganh.Location = new System.Drawing.Point(8, 27);
            this.lblMaNganh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaNganh.Name = "lblMaNganh";
            this.lblMaNganh.Size = new System.Drawing.Size(58, 13);
            this.lblMaNganh.TabIndex = 1;
            this.lblMaNganh.Text = "Mã ngành:";
            // 
            // btnSuaNganh
            // 
            this.btnSuaNganh.Location = new System.Drawing.Point(102, 100);
            this.btnSuaNganh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaNganh.Name = "btnSuaNganh";
            this.btnSuaNganh.Size = new System.Drawing.Size(52, 19);
            this.btnSuaNganh.TabIndex = 6;
            this.btnSuaNganh.Text = "Sửa";
            this.btnSuaNganh.UseVisualStyleBackColor = true;
            this.btnSuaNganh.Click += new System.EventHandler(this.btnSuaNganh_Click);
            // 
            // lblTenNganh
            // 
            this.lblTenNganh.AutoSize = true;
            this.lblTenNganh.Location = new System.Drawing.Point(8, 50);
            this.lblTenNganh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenNganh.Name = "lblTenNganh";
            this.lblTenNganh.Size = new System.Drawing.Size(62, 13);
            this.lblTenNganh.TabIndex = 3;
            this.lblTenNganh.Text = "Tên ngành:";
            // 
            // btnXoaNganh
            // 
            this.btnXoaNganh.Location = new System.Drawing.Point(46, 100);
            this.btnXoaNganh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaNganh.Name = "btnXoaNganh";
            this.btnXoaNganh.Size = new System.Drawing.Size(52, 19);
            this.btnXoaNganh.TabIndex = 7;
            this.btnXoaNganh.Text = "Xóa";
            this.btnXoaNganh.UseVisualStyleBackColor = true;
            this.btnXoaNganh.Click += new System.EventHandler(this.btnXoaNganh_Click);
            // 
            // txtTenNganh
            // 
            this.txtTenNganh.Location = new System.Drawing.Point(77, 47);
            this.txtTenNganh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNganh.Name = "txtTenNganh";
            this.txtTenNganh.Size = new System.Drawing.Size(134, 20);
            this.txtTenNganh.TabIndex = 3;
            // 
            // dKHPDataSet
            // 
            this.dKHPDataSet.DataSetName = "DKHPDataSet";
            this.dKHPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dKHPDataSet;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // dgvDSNganh
            // 
            this.dgvDSNganh.AllowUserToAddRows = false;
            this.dgvDSNganh.AllowUserToDeleteRows = false;
            this.dgvDSNganh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNganh.Location = new System.Drawing.Point(9, 10);
            this.dgvDSNganh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSNganh.Name = "dgvDSNganh";
            this.dgvDSNganh.ReadOnly = true;
            this.dgvDSNganh.RowHeadersWidth = 51;
            this.dgvDSNganh.RowTemplate.Height = 24;
            this.dgvDSNganh.Size = new System.Drawing.Size(362, 346);
            this.dgvDSNganh.TabIndex = 10;
            this.dgvDSNganh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNganh_CellClick);
            // 
            // Nganh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvDSNganh);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Nganh";
            this.Text = "Quản lý ngành đào tạo";
            this.Load += new System.EventHandler(this.Nganh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNganh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboThuocKhoa;
        private System.Windows.Forms.Label lblThuocKhoa;
        private System.Windows.Forms.TextBox txtMaNganh;
        private System.Windows.Forms.Button btnThemNganh;
        private System.Windows.Forms.Label lblMaNganh;
        private System.Windows.Forms.Button btnSuaNganh;
        private System.Windows.Forms.Label lblTenNganh;
        private System.Windows.Forms.Button btnXoaNganh;
        private System.Windows.Forms.TextBox txtTenNganh;
        private DKHPDataSet dKHPDataSet;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DKHPDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
        private System.Windows.Forms.DataGridView dgvDSNganh;
    }
}