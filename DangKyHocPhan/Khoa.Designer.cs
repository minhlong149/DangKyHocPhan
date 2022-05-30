
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNganh = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(7, 25);
            this.lblMaKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(52, 13);
            this.lblMaKhoa.TabIndex = 1;
            this.lblMaKhoa.Text = "Mã khoa:";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(65, 23);
            this.txtMaKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(145, 20);
            this.txtMaKhoa.TabIndex = 2;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(65, 46);
            this.txtTenKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(145, 20);
            this.txtTenKhoa.TabIndex = 4;
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(7, 48);
            this.lblTenKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(56, 13);
            this.lblTenKhoa.TabIndex = 3;
            this.lblTenKhoa.Text = "Tên khoa:";
            // 
            // btnThemKhoa
            // 
            this.btnThemKhoa.Location = new System.Drawing.Point(158, 74);
            this.btnThemKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemKhoa.Name = "btnThemKhoa";
            this.btnThemKhoa.Size = new System.Drawing.Size(52, 19);
            this.btnThemKhoa.TabIndex = 5;
            this.btnThemKhoa.Text = "Thêm";
            this.btnThemKhoa.UseVisualStyleBackColor = true;
            this.btnThemKhoa.Click += new System.EventHandler(this.btnThemKhoa_Click);
            // 
            // btnSuaKhoa
            // 
            this.btnSuaKhoa.Location = new System.Drawing.Point(101, 74);
            this.btnSuaKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaKhoa.Name = "btnSuaKhoa";
            this.btnSuaKhoa.Size = new System.Drawing.Size(52, 19);
            this.btnSuaKhoa.TabIndex = 6;
            this.btnSuaKhoa.Text = "Sửa";
            this.btnSuaKhoa.UseVisualStyleBackColor = true;
            this.btnSuaKhoa.Click += new System.EventHandler(this.btnSuaKhoa_Click);
            // 
            // btnXoaKhoa
            // 
            this.btnXoaKhoa.Location = new System.Drawing.Point(45, 74);
            this.btnXoaKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaKhoa.Name = "btnXoaKhoa";
            this.btnXoaKhoa.Size = new System.Drawing.Size(52, 19);
            this.btnXoaKhoa.TabIndex = 7;
            this.btnXoaKhoa.Text = "Xóa";
            this.btnXoaKhoa.UseVisualStyleBackColor = true;
            this.btnXoaKhoa.Click += new System.EventHandler(this.btnXoaKhoa_Click);
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
            this.groupBox1.Location = new System.Drawing.Point(376, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(214, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khoa";
            // 
            // dgvDSKhoa
            // 
            this.dgvDSKhoa.AllowUserToAddRows = false;
            this.dgvDSKhoa.AllowUserToDeleteRows = false;
            this.dgvDSKhoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSKhoa.Location = new System.Drawing.Point(9, 29);
            this.dgvDSKhoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSKhoa.Name = "dgvDSKhoa";
            this.dgvDSKhoa.ReadOnly = true;
            this.dgvDSKhoa.RowHeadersWidth = 51;
            this.dgvDSKhoa.RowTemplate.Height = 24;
            this.dgvDSKhoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSKhoa.Size = new System.Drawing.Size(363, 327);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "QUẢN LÝ KHOA";
            // 
            // btnNganh
            // 
            this.btnNganh.Location = new System.Drawing.Point(505, 328);
            this.btnNganh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNganh.Name = "btnNganh";
            this.btnNganh.Size = new System.Drawing.Size(86, 28);
            this.btnNganh.TabIndex = 11;
            this.btnNganh.Text = "Quản lý ngành";
            this.btnNganh.UseVisualStyleBackColor = true;
            this.btnNganh.Click += new System.EventHandler(this.btnNganh_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(442, 328);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 28);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Quay về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Khoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNganh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSKhoa);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Khoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khoa";
            this.Load += new System.EventHandler(this.Khoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dKHPDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNganh;
        private System.Windows.Forms.Button btnBack;
    }
}