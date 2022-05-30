namespace DangKyHocPhan
{
    partial class PhieuThuHocPhi
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
            this.title = new System.Windows.Forms.Label();
            this.grbox_nlp = new System.Windows.Forms.GroupBox();
            this.date_picker_ngay_lap = new System.Windows.Forms.DateTimePicker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_dhp = new System.Windows.Forms.Button();
            this.grbox_soPhieu = new System.Windows.Forms.GroupBox();
            this.txtBox_soPhieu = new System.Windows.Forms.TextBox();
            this.grbox_mssv = new System.Windows.Forms.GroupBox();
            this.txtbox_mssv = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.grBox_soTien = new System.Windows.Forms.GroupBox();
            this.txt_soTien = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grbox_nlp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbox_soPhieu.SuspendLayout();
            this.grbox_mssv.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.grBox_soTien.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoEllipsis = true;
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Location = new System.Drawing.Point(198, 9);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.title.Size = new System.Drawing.Size(241, 33);
            this.title.TabIndex = 0;
            this.title.Text = "PHIẾU THU HỌC PHÍ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // grbox_nlp
            // 
            this.grbox_nlp.Controls.Add(this.date_picker_ngay_lap);
            this.grbox_nlp.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbox_nlp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_nlp.Location = new System.Drawing.Point(315, 2);
            this.grbox_nlp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbox_nlp.Name = "grbox_nlp";
            this.grbox_nlp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbox_nlp.Size = new System.Drawing.Size(247, 55);
            this.grbox_nlp.TabIndex = 1;
            this.grbox_nlp.TabStop = false;
            this.grbox_nlp.Text = "Ngày lập phiếu";
            this.grbox_nlp.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // date_picker_ngay_lap
            // 
            this.date_picker_ngay_lap.CustomFormat = "dd-MM-yyyy";
            this.date_picker_ngay_lap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.date_picker_ngay_lap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_picker_ngay_lap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_picker_ngay_lap.Location = new System.Drawing.Point(2, 21);
            this.date_picker_ngay_lap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date_picker_ngay_lap.Name = "date_picker_ngay_lap";
            this.date_picker_ngay_lap.Size = new System.Drawing.Size(243, 29);
            this.date_picker_ngay_lap.TabIndex = 2;
            this.date_picker_ngay_lap.Value = new System.DateTime(2022, 5, 30, 9, 51, 13, 0);
            this.date_picker_ngay_lap.ValueChanged += new System.EventHandler(this.date_picker_ngay_lap_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 57);
            this.panel1.TabIndex = 3;
            // 
            // btn_dhp
            // 
            this.btn_dhp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_dhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dhp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_dhp.Location = new System.Drawing.Point(82, 89);
            this.btn_dhp.Name = "btn_dhp";
            this.btn_dhp.Size = new System.Drawing.Size(157, 41);
            this.btn_dhp.TabIndex = 0;
            this.btn_dhp.Text = "Đóng Học Phí";
            this.btn_dhp.UseVisualStyleBackColor = false;
            this.btn_dhp.Click += new System.EventHandler(this.btn_dhp_Click);
            // 
            // grbox_soPhieu
            // 
            this.grbox_soPhieu.Controls.Add(this.txtBox_soPhieu);
            this.grbox_soPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbox_soPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_soPhieu.Location = new System.Drawing.Point(65, 3);
            this.grbox_soPhieu.Name = "grbox_soPhieu";
            this.grbox_soPhieu.Size = new System.Drawing.Size(245, 59);
            this.grbox_soPhieu.TabIndex = 3;
            this.grbox_soPhieu.TabStop = false;
            this.grbox_soPhieu.Text = "Số phiếu";
            this.grbox_soPhieu.Enter += new System.EventHandler(this.grbox_soPhieu_Enter);
            // 
            // txtBox_soPhieu
            // 
            this.txtBox_soPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox_soPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_soPhieu.Location = new System.Drawing.Point(3, 22);
            this.txtBox_soPhieu.Name = "txtBox_soPhieu";
            this.txtBox_soPhieu.ReadOnly = true;
            this.txtBox_soPhieu.Size = new System.Drawing.Size(239, 31);
            this.txtBox_soPhieu.TabIndex = 0;
            // 
            // grbox_mssv
            // 
            this.grbox_mssv.Controls.Add(this.txtbox_mssv);
            this.grbox_mssv.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbox_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_mssv.Location = new System.Drawing.Point(65, 145);
            this.grbox_mssv.Name = "grbox_mssv";
            this.grbox_mssv.Size = new System.Drawing.Size(245, 55);
            this.grbox_mssv.TabIndex = 4;
            this.grbox_mssv.TabStop = false;
            this.grbox_mssv.Text = "Mã số sinh viên";
            // 
            // txtbox_mssv
            // 
            this.txtbox_mssv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_mssv.Location = new System.Drawing.Point(3, 22);
            this.txtbox_mssv.Name = "txtbox_mssv";
            this.txtbox_mssv.ReadOnly = true;
            this.txtbox_mssv.Size = new System.Drawing.Size(239, 26);
            this.txtbox_mssv.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.grbox_nlp, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.grbox_mssv, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.grBox_soTien, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbox_soPhieu, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 57);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(628, 284);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // grBox_soTien
            // 
            this.grBox_soTien.Controls.Add(this.btn_dhp);
            this.grBox_soTien.Controls.Add(this.txt_soTien);
            this.grBox_soTien.Dock = System.Windows.Forms.DockStyle.Top;
            this.grBox_soTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox_soTien.Location = new System.Drawing.Point(316, 145);
            this.grBox_soTien.Name = "grBox_soTien";
            this.grBox_soTien.Size = new System.Drawing.Size(245, 136);
            this.grBox_soTien.TabIndex = 5;
            this.grBox_soTien.TabStop = false;
            this.grBox_soTien.Text = "Số tiền";
            this.grBox_soTien.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // txt_soTien
            // 
            this.txt_soTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_soTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_soTien.Location = new System.Drawing.Point(3, 22);
            this.txt_soTien.Name = "txt_soTien";
            this.txt_soTien.ReadOnly = true;
            this.txt_soTien.Size = new System.Drawing.Size(239, 29);
            this.txt_soTien.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 43);
            this.panel2.TabIndex = 4;
            // 
            // PhieuThuHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 384);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PhieuThuHocPhi";
            this.Text = "Phiếu thu học phí";
            this.Load += new System.EventHandler(this.PhieuThuHocPhi_Load);
            this.grbox_nlp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grbox_soPhieu.ResumeLayout(false);
            this.grbox_soPhieu.PerformLayout();
            this.grbox_mssv.ResumeLayout(false);
            this.grbox_mssv.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grBox_soTien.ResumeLayout(false);
            this.grBox_soTien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox grbox_nlp;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DateTimePicker date_picker_ngay_lap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_dhp;
        private System.Windows.Forms.GroupBox grbox_soPhieu;
        private System.Windows.Forms.TextBox txtBox_soPhieu;
        private System.Windows.Forms.GroupBox grbox_mssv;
        private System.Windows.Forms.TextBox txtbox_mssv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grBox_soTien;
        private System.Windows.Forms.TextBox txt_soTien;
        private System.Windows.Forms.Panel panel2;
    }
}