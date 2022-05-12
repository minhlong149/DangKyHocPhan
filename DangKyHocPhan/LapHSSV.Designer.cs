
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LapHSSV));
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.pickNS = new System.Windows.Forms.DateTimePicker();
            this.CBoxTinh = new System.Windows.Forms.ComboBox();
            this.CBoxDT = new System.Windows.Forms.ComboBox();
            this.CBoxNganh = new System.Windows.Forms.ComboBox();
            this.btnLHS = new System.Windows.Forms.Button();
            this.btnThoatLHS = new System.Windows.Forms.Button();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.CBoxHuyen = new System.Windows.Forms.ComboBox();
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
            this.CBoxTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxTinh.FormattingEnabled = true;
            this.CBoxTinh.Items.AddRange(new object[] {
            "An Giang\t",
            "Bà Rịa – Vũng Tàu\t",
            "Bắc Giang\t",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ",
            "Cao Bằng",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam\t",
            "Hà Nội\t",
            "Hà Tĩnh\t",
            "Hải Dương\t",
            "Hải Phòng\t",
            "Hậu Giang\t",
            "Hòa Bình\t",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum\t",
            "Lai Châu\t",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "TP Hồ Chí Minh",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.CBoxTinh.Location = new System.Drawing.Point(373, 572);
            this.CBoxTinh.Name = "CBoxTinh";
            this.CBoxTinh.Size = new System.Drawing.Size(138, 28);
            this.CBoxTinh.TabIndex = 11;
            // 
            // CBoxDT
            // 
            this.CBoxDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxDT.FormattingEnabled = true;
            this.CBoxDT.Items.AddRange(new object[] {
            "Con liệt sĩ",
            "Con thương binh",
            "Con vùng sâu/vùng xa"});
            this.CBoxDT.Location = new System.Drawing.Point(304, 520);
            this.CBoxDT.Name = "CBoxDT";
            this.CBoxDT.Size = new System.Drawing.Size(207, 28);
            this.CBoxDT.TabIndex = 13;
            // 
            // CBoxNganh
            // 
            this.CBoxNganh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxNganh.FormattingEnabled = true;
            this.CBoxNganh.Items.AddRange(new object[] {
            "Ngành Công nghệ Thông tin",
            "Ngành Hệ thống Thông tin",
            "Ngành Khoa học Máy tính",
            "Ngành Kỹ thuật Phần mềm",
            "Ngành Kỹ thuật Máy tính",
            "Ngành Mạng máy tính & Truyền thông Dữ liệu",
            "Ngành An toàn Thông tin",
            "Ngành Thương mại Điện tử"});
            this.CBoxNganh.Location = new System.Drawing.Point(243, 623);
            this.CBoxNganh.Name = "CBoxNganh";
            this.CBoxNganh.Size = new System.Drawing.Size(268, 28);
            this.CBoxNganh.TabIndex = 14;
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
            this.CBoxHuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxHuyen.FormattingEnabled = true;
            this.CBoxHuyen.Items.AddRange(new object[] {
            "An Giang\t",
            "Bà Rịa – Vũng Tàu\t",
            "Bắc Giang\t",
            "Bắc Kạn",
            "Bạc Liêu",
            "Bắc Ninh",
            "Bến Tre",
            "Bình Định",
            "Bình Dương",
            "Bình Phước",
            "Bình Thuận",
            "Cà Mau",
            "Cần Thơ",
            "Cao Bằng",
            "Đà Nẵng",
            "Đắk Lắk",
            "Đắk Nông",
            "Điện Biên",
            "Đồng Nai",
            "Đồng Tháp",
            "Gia Lai",
            "Hà Giang",
            "Hà Nam\t",
            "Hà Nội\t",
            "Hà Tĩnh\t",
            "Hải Dương\t",
            "Hải Phòng\t",
            "Hậu Giang\t",
            "Hòa Bình\t",
            "Hưng Yên",
            "Khánh Hòa",
            "Kiên Giang",
            "Kon Tum\t",
            "Lai Châu\t",
            "Lâm Đồng",
            "Lạng Sơn",
            "Lào Cai",
            "Long An",
            "Nam Định",
            "Nghệ An",
            "Ninh Bình",
            "Ninh Thuận",
            "Phú Thọ",
            "Phú Yên",
            "Quảng Bình",
            "Quảng Nam",
            "Quảng Ngãi",
            "Quảng Ninh",
            "Quảng Trị",
            "Sóc Trăng",
            "Sơn La",
            "Tây Ninh",
            "Thái Bình",
            "Thái Nguyên",
            "Thanh Hóa",
            "Thừa Thiên Huế",
            "Tiền Giang",
            "TP Hồ Chí Minh",
            "Trà Vinh",
            "Tuyên Quang",
            "Vĩnh Long",
            "Vĩnh Phúc",
            "Yên Bái"});
            this.CBoxHuyen.Location = new System.Drawing.Point(163, 572);
            this.CBoxHuyen.Name = "CBoxHuyen";
            this.CBoxHuyen.Size = new System.Drawing.Size(138, 28);
            this.CBoxHuyen.TabIndex = 19;
            // 
            // LapHSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker pickNS;
        private System.Windows.Forms.ComboBox CBoxTinh;
        private System.Windows.Forms.ComboBox CBoxDT;
        private System.Windows.Forms.ComboBox CBoxNganh;
        private System.Windows.Forms.Button btnLHS;
        private System.Windows.Forms.Button btnThoatLHS;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.ComboBox CBoxHuyen;
    }
}
