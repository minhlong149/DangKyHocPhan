
namespace DangKyHocPhan
{
    partial class DSMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDSMH = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(421, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Từ khóa";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Location = new System.Drawing.Point(489, 54);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(215, 22);
            this.txtTimKiem.TabIndex = 3;
            // 
            // dgvDSMH
            // 
            this.dgvDSMH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.SoTiet,
            this.LoaiMon});
            this.dgvDSMH.Location = new System.Drawing.Point(-2, 104);
            this.dgvDSMH.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSMH.MultiSelect = false;
            this.dgvDSMH.Name = "dgvDSMH";
            this.dgvDSMH.RowHeadersWidth = 51;
            this.dgvDSMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMH.Size = new System.Drawing.Size(869, 400);
            this.dgvDSMH.TabIndex = 4;
            this.dgvDSMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMH_CellClick);
            this.dgvDSMH.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMH_CellDoubleClick);
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.FillWeight = 80F;
            this.MaMon.HeaderText = "Mã môn học";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.FillWeight = 80F;
            this.TenMon.HeaderText = "Tên môn học";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            // 
            // SoTiet
            // 
            this.SoTiet.DataPropertyName = "SoTiet";
            this.SoTiet.FillWeight = 80F;
            this.SoTiet.HeaderText = "Số Tiết";
            this.SoTiet.MinimumWidth = 6;
            this.SoTiet.Name = "SoTiet";
            // 
            // LoaiMon
            // 
            this.LoaiMon.DataPropertyName = "LoaiMon";
            this.LoaiMon.FillWeight = 80F;
            this.LoaiMon.HeaderText = "Loại môn";
            this.LoaiMon.MinimumWidth = 6;
            this.LoaiMon.Name = "LoaiMon";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(712, 51);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemmoi.Location = new System.Drawing.Point(820, 51);
            this.btnThemmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(100, 28);
            this.btnThemmoi.TabIndex = 6;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // DSMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 503);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvDSMH);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Name = "DSMonHoc";
            this.Text = "DSMonHoc";
            this.Load += new System.EventHandler(this.DSMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDSMH;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiMon;
    }
}