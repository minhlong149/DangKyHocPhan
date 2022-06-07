
namespace DangKyHocPhan
{
    partial class DSMonHocMo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSMonHocMo));
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSMHMo = new System.Windows.Forms.DataGridView();
            this.MaHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHMo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(324, 71);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(215, 24);
            this.txtTimKiem.TabIndex = 6;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(547, 71);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemmoi.Location = new System.Drawing.Point(655, 71);
            this.btnThemmoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(100, 28);
            this.btnThemmoi.TabIndex = 8;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 9;
            // 
            // dgvDSMHMo
            // 
            this.dgvDSMHMo.AllowUserToAddRows = false;
            this.dgvDSMHMo.AllowUserToDeleteRows = false;
            this.dgvDSMHMo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSMHMo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSMHMo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMHMo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHK,
            this.MonHoc});
            this.dgvDSMHMo.Location = new System.Drawing.Point(-4, 120);
            this.dgvDSMHMo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSMHMo.MultiSelect = false;
            this.dgvDSMHMo.Name = "dgvDSMHMo";
            this.dgvDSMHMo.ReadOnly = true;
            this.dgvDSMHMo.RowHeadersWidth = 51;
            this.dgvDSMHMo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMHMo.Size = new System.Drawing.Size(723, 333);
            this.dgvDSMHMo.TabIndex = 10;
            this.dgvDSMHMo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMHMo_CellClick);
            this.dgvDSMHMo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMHMo_CellContentDoubleClick);
            // 
            // MaHK
            // 
            this.MaHK.DataPropertyName = "MaHK";
            this.MaHK.HeaderText = "Mã học kỳ";
            this.MaHK.MinimumWidth = 6;
            this.MaHK.Name = "MaHK";
            this.MaHK.ReadOnly = true;
            // 
            // MonHoc
            // 
            this.MonHoc.DataPropertyName = "MonHoc";
            this.MonHoc.HeaderText = "Mã môn học";
            this.MonHoc.MinimumWidth = 6;
            this.MonHoc.Name = "MonHoc";
            this.MonHoc.ReadOnly = true;
            // 
            // DSMonHocMo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 440);
            this.Controls.Add(this.dgvDSMHMo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.DoubleBuffered = true;
            this.Name = "DSMonHocMo";
            this.Text = "DSMonHocMo";
            this.Load += new System.EventHandler(this.DSMonHocMo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHMo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSMHMo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonHoc;
    }
}