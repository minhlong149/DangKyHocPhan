
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
            this.components = new System.ComponentModel.Container();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.btnThemKhoa = new System.Windows.Forms.Button();
            this.btnSuaKhoa = new System.Windows.Forms.Button();
            this.btnXoaKhoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvDSKhoa = new System.Windows.Forms.DataGridView();
            this.kHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dKHPDataSet = new DangKyHocPhan.DKHPDataSet();
            this.kHOATableAdapter = new DangKyHocPhan.DKHPDataSetTableAdapters.KHOATableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(9, 31);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(66, 17);
            this.lblMaKhoa.TabIndex = 1;
            this.lblMaKhoa.Text = "Mã khoa:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(87, 28);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(192, 22);
            this.txtMaKhoa.TabIndex = 2;
            this.txtMaKhoa.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(87, 56);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(192, 22);
            this.txtTenKhoa.TabIndex = 4;
            this.txtTenKhoa.TextChanged += new System.EventHandler(this.txtTenKhoa_TextChanged);
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(9, 59);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(72, 17);
            this.lblTenKhoa.TabIndex = 3;
            this.lblTenKhoa.Text = "Tên khoa:";
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Location = new System.Drawing.Point(210, 91);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(69, 23);
            this.btnThemKhoa.TabIndex = 5;
            this.btnThemKhoa.Text = "Thêm";
            this.btnThemKhoa.UseVisualStyleBackColor = true;
            this.btnThemKhoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Location = new System.Drawing.Point(135, 91);
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.Size = new System.Drawing.Size(69, 23);
            this.btnSuaKhoa.TabIndex = 6;
            this.btnSuaKhoa.Text = "Sửa";
            this.btnSuaKhoa.UseVisualStyleBackColor = true;
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Location = new System.Drawing.Point(60, 91);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(69, 23);
            this.btnXoaKhoa.TabIndex = 7;
            this.btnXoaKhoa.Text = "Xóa";
            this.btnXoaKhoa.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(this.btnThemKhoa);
            this.groupBox1.Controls.Add(this.lblMaKhoa);
            this.groupBox1.Controls.Add(this.btnSuaKhoa);
            this.groupBox1.Controls.Add(this.lblTenKhoa);
            this.groupBox1.Controls.Add(this.btnXoaKhoa);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Location = new System.Drawing.Point(502, 309);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 129);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // dgvDSKhoa
            // 
            this.dgvDSKhoa.AllowUserToAddRows = false;
            this.dgvDSKhoa.AllowUserToDeleteRows = false;
            this.dgvDSKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhoa.Location = new System.Drawing.Point(12, 12);
            this.dgvDSKhoa.Name = "dgvDSKhoa";
            this.dgvDSKhoa.ReadOnly = true;
            this.dgvDSKhoa.RowHeadersWidth = 51;
            this.dgvDSKhoa.RowTemplate.Height = 24;
            this.dgvDSKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKhoa.Size = new System.Drawing.Size(484, 426);
            this.dgvDSKhoa.TabIndex = 9;
            this.dgvDSKhoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKhoa_CellClick);
            this.dgvDSKhoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSKhoa_CellContentClick);
            // 
            // kHOABindingSource
            // 
            this.kHOABindingSource.DataMember = "KHOA";
            this.kHOABindingSource.DataSource = this.dKHPDataSet;
            // 
            // dKHPDataSet
            // 
            this.dKHPDataSet.DataSetName = "DKHPDataSet";
            this.dKHPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHOATableAdapter
            // 
            this.kHOATableAdapter.ClearBeforeFill = true;
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvDSKhoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "Khoa";
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.Khoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvDSKhoa;
        private DKHPDataSet dKHPDataSet;
        private System.Windows.Forms.BindingSource kHOABindingSource;
        private DKHPDataSetTableAdapters.KHOATableAdapter kHOATableAdapter;
    }
}