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
            this.ComboBox_SoPhieu = new System.Windows.Forms.ComboBox();
            this.thongTin = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Mon_PTHP = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grBox_soTien = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.sotienPhaiDong = new System.Windows.Forms.Label();
            this.grbox_mssv = new System.Windows.Forms.GroupBox();
            this.txtbox_mssv = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_quay_lai = new System.Windows.Forms.Button();
            this.grbox_nlp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grbox_soPhieu.SuspendLayout();
            this.thongTin.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mon_PTHP)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.grBox_soTien.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.grbox_mssv.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoEllipsis = true;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(5);
            this.title.Size = new System.Drawing.Size(986, 68);
            this.title.TabIndex = 0;
            this.title.Text = "PHIẾU THU HỌC PHÍ";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // grbox_nlp
            // 
            this.grbox_nlp.Controls.Add(this.date_picker_ngay_lap);
            this.grbox_nlp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbox_nlp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_nlp.Location = new System.Drawing.Point(3, 2);
            this.grbox_nlp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbox_nlp.Name = "grbox_nlp";
            this.grbox_nlp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbox_nlp.Size = new System.Drawing.Size(440, 83);
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
            this.date_picker_ngay_lap.Location = new System.Drawing.Point(3, 25);
            this.date_picker_ngay_lap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_picker_ngay_lap.Name = "date_picker_ngay_lap";
            this.date_picker_ngay_lap.Size = new System.Drawing.Size(434, 34);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 70);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btn_dhp
            // 
            this.btn_dhp.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_dhp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dhp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_dhp.Location = new System.Drawing.Point(753, 4);
            this.btn_dhp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_dhp.Name = "btn_dhp";
            this.btn_dhp.Size = new System.Drawing.Size(209, 50);
            this.btn_dhp.TabIndex = 0;
            this.btn_dhp.Text = "Đóng Học Phí";
            this.btn_dhp.UseVisualStyleBackColor = false;
            this.btn_dhp.Click += new System.EventHandler(this.btn_dhp_Click);
            // 
            // grbox_soPhieu
            // 
            this.grbox_soPhieu.Controls.Add(this.ComboBox_SoPhieu);
            this.grbox_soPhieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbox_soPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_soPhieu.Location = new System.Drawing.Point(53, 4);
            this.grbox_soPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.grbox_soPhieu.Name = "grbox_soPhieu";
            this.grbox_soPhieu.Padding = new System.Windows.Forms.Padding(4);
            this.grbox_soPhieu.Size = new System.Drawing.Size(431, 78);
            this.grbox_soPhieu.TabIndex = 3;
            this.grbox_soPhieu.TabStop = false;
            this.grbox_soPhieu.Text = "Số phiếu";
            this.grbox_soPhieu.Enter += new System.EventHandler(this.grbox_soPhieu_Enter);
            // 
            // ComboBox_SoPhieu
            // 
            this.ComboBox_SoPhieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComboBox_SoPhieu.FormattingEnabled = true;
            this.ComboBox_SoPhieu.Location = new System.Drawing.Point(4, 27);
            this.ComboBox_SoPhieu.Name = "ComboBox_SoPhieu";
            this.ComboBox_SoPhieu.Size = new System.Drawing.Size(423, 33);
            this.ComboBox_SoPhieu.TabIndex = 1;
            this.ComboBox_SoPhieu.SelectedIndexChanged += new System.EventHandler(this.process_event_combobox);
            this.ComboBox_SoPhieu.DropDownClosed += new System.EventHandler(this.ComboBox_SoPhieu_DropDownClosed);
            // 
            // thongTin
            // 
            this.thongTin.BackColor = System.Drawing.SystemColors.Control;
            this.thongTin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thongTin.ColumnCount = 2;
            this.thongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.thongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.thongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.thongTin.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.thongTin.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.thongTin.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.thongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thongTin.Location = new System.Drawing.Point(0, 70);
            this.thongTin.Margin = new System.Windows.Forms.Padding(4);
            this.thongTin.Name = "thongTin";
            this.thongTin.RowCount = 1;
            this.thongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.thongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.thongTin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 351F));
            this.thongTin.Size = new System.Drawing.Size(988, 351);
            this.thongTin.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.2459F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.7541F));
            this.tableLayoutPanel1.Controls.Add(this.grbox_soPhieu, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_Mon_PTHP, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.92754F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.07246F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 345);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dgv_Mon_PTHP
            // 
            this.dgv_Mon_PTHP.AllowUserToAddRows = false;
            this.dgv_Mon_PTHP.AllowUserToDeleteRows = false;
            this.dgv_Mon_PTHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Mon_PTHP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon});
            this.dgv_Mon_PTHP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Mon_PTHP.Location = new System.Drawing.Point(52, 89);
            this.dgv_Mon_PTHP.Name = "dgv_Mon_PTHP";
            this.dgv_Mon_PTHP.ReadOnly = true;
            this.dgv_Mon_PTHP.RowHeadersWidth = 51;
            this.dgv_Mon_PTHP.RowTemplate.Height = 24;
            this.dgv_Mon_PTHP.Size = new System.Drawing.Size(433, 253);
            this.dgv_Mon_PTHP.TabIndex = 4;
            this.dgv_Mon_PTHP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Mon_PTHP_CellContentClick);
            // 
            // MaMon
            // 
            this.MaMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã Môn";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            this.MaMon.Width = 84;
            // 
            // TenMon
            // 
            this.TenMon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Môn";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.39344F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.606558F));
            this.tableLayoutPanel2.Controls.Add(this.grbox_nlp, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grBox_soTien, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.grbox_mssv, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(497, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.2907F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.61628F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.09302F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(488, 345);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // grBox_soTien
            // 
            this.grBox_soTien.Controls.Add(this.tableLayoutPanel3);
            this.grBox_soTien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grBox_soTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBox_soTien.Location = new System.Drawing.Point(4, 186);
            this.grBox_soTien.Margin = new System.Windows.Forms.Padding(4);
            this.grBox_soTien.Name = "grBox_soTien";
            this.grBox_soTien.Padding = new System.Windows.Forms.Padding(4);
            this.grBox_soTien.Size = new System.Drawing.Size(438, 155);
            this.grBox_soTien.TabIndex = 5;
            this.grBox_soTien.TabStop = false;
            this.grBox_soTien.Text = "Số tiền phải đóng";
            this.grBox_soTien.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.sotienPhaiDong, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 27);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(430, 124);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // sotienPhaiDong
            // 
            this.sotienPhaiDong.AutoSize = true;
            this.sotienPhaiDong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sotienPhaiDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sotienPhaiDong.ForeColor = System.Drawing.Color.Red;
            this.sotienPhaiDong.Location = new System.Drawing.Point(46, 37);
            this.sotienPhaiDong.Name = "sotienPhaiDong";
            this.sotienPhaiDong.Size = new System.Drawing.Size(338, 74);
            this.sotienPhaiDong.TabIndex = 0;
            this.sotienPhaiDong.Text = "Đã hoàn thành";
            this.sotienPhaiDong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.sotienPhaiDong.Click += new System.EventHandler(this.sotienPhaiDong_Click);
            // 
            // grbox_mssv
            // 
            this.grbox_mssv.Controls.Add(this.txtbox_mssv);
            this.grbox_mssv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbox_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbox_mssv.Location = new System.Drawing.Point(4, 91);
            this.grbox_mssv.Margin = new System.Windows.Forms.Padding(4);
            this.grbox_mssv.Name = "grbox_mssv";
            this.grbox_mssv.Padding = new System.Windows.Forms.Padding(4);
            this.grbox_mssv.Size = new System.Drawing.Size(438, 87);
            this.grbox_mssv.TabIndex = 4;
            this.grbox_mssv.TabStop = false;
            this.grbox_mssv.Text = "Mã số sinh viên";
            // 
            // txtbox_mssv
            // 
            this.txtbox_mssv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtbox_mssv.Location = new System.Drawing.Point(4, 27);
            this.txtbox_mssv.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_mssv.Name = "txtbox_mssv";
            this.txtbox_mssv.ReadOnly = true;
            this.txtbox_mssv.Size = new System.Drawing.Size(430, 30);
            this.txtbox_mssv.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_quay_lai);
            this.panel2.Controls.Add(this.btn_dhp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 421);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(988, 53);
            this.panel2.TabIndex = 4;
            // 
            // btn_quay_lai
            // 
            this.btn_quay_lai.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_quay_lai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quay_lai.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_quay_lai.Location = new System.Drawing.Point(525, 4);
            this.btn_quay_lai.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quay_lai.Name = "btn_quay_lai";
            this.btn_quay_lai.Size = new System.Drawing.Size(209, 50);
            this.btn_quay_lai.TabIndex = 1;
            this.btn_quay_lai.Text = "Quay lại";
            this.btn_quay_lai.UseVisualStyleBackColor = false;
            this.btn_quay_lai.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhieuThuHocPhi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 474);
            this.Controls.Add(this.thongTin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PhieuThuHocPhi";
            this.Text = "Phiếu thu học phí";
            this.Load += new System.EventHandler(this.PhieuThuHocPhi_Load);
            this.grbox_nlp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grbox_soPhieu.ResumeLayout(false);
            this.thongTin.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mon_PTHP)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grBox_soTien.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.grbox_mssv.ResumeLayout(false);
            this.grbox_mssv.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel thongTin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox ComboBox_SoPhieu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label sotienPhaiDong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grBox_soTien;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox grbox_mssv;
        private System.Windows.Forms.TextBox txtbox_mssv;
        private System.Windows.Forms.DataGridView dgv_Mon_PTHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.Button btn_quay_lai;
    }
}