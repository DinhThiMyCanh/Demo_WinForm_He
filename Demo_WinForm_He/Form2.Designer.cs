
namespace Demo_WinForm_He
{
    partial class frmThongTinSV
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.chkTiengAnh = new System.Windows.Forms.CheckBox();
            this.chkTiengNhat = new System.Windows.Forms.CheckBox();
            this.cboQueQuan = new System.Windows.Forms.ComboBox();
            this.lstDSMH = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnXemThongTin = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(241, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH THÔNG TIN SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Location = new System.Drawing.Point(49, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giới tính";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTiengNhat);
            this.groupBox2.Controls.Add(this.chkTiengAnh);
            this.groupBox2.Location = new System.Drawing.Point(49, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 103);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trình độ ngoại ngữ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quê quán";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstDSMH);
            this.groupBox3.Location = new System.Drawing.Point(49, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 192);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách môn học";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(221, 73);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(296, 35);
            this.txtHoTen.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(221, 125);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(296, 35);
            this.dtpNgaySinh.TabIndex = 8;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(161, 46);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(89, 33);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(295, 46);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(69, 33);
            this.rdNu.TabIndex = 1;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // chkTiengAnh
            // 
            this.chkTiengAnh.AutoSize = true;
            this.chkTiengAnh.Location = new System.Drawing.Point(161, 34);
            this.chkTiengAnh.Name = "chkTiengAnh";
            this.chkTiengAnh.Size = new System.Drawing.Size(149, 33);
            this.chkTiengAnh.TabIndex = 0;
            this.chkTiengAnh.Text = "Tiếng Anh";
            this.chkTiengAnh.UseVisualStyleBackColor = true;
            // 
            // chkTiengNhat
            // 
            this.chkTiengNhat.AutoSize = true;
            this.chkTiengNhat.Location = new System.Drawing.Point(316, 34);
            this.chkTiengNhat.Name = "chkTiengNhat";
            this.chkTiengNhat.Size = new System.Drawing.Size(158, 33);
            this.chkTiengNhat.TabIndex = 1;
            this.chkTiengNhat.Text = "Tiếng Nhật";
            this.chkTiengNhat.UseVisualStyleBackColor = true;
            // 
            // cboQueQuan
            // 
            this.cboQueQuan.FormattingEnabled = true;
            this.cboQueQuan.Items.AddRange(new object[] {
            "Bình Định",
            "Phú Yên",
            "Gia Lai"});
            this.cboQueQuan.Location = new System.Drawing.Point(221, 402);
            this.cboQueQuan.Name = "cboQueQuan";
            this.cboQueQuan.Size = new System.Drawing.Size(296, 37);
            this.cboQueQuan.TabIndex = 9;
            this.cboQueQuan.Text = "Bình Định";
            // 
            // lstDSMH
            // 
            this.lstDSMH.FormattingEnabled = true;
            this.lstDSMH.ItemHeight = 29;
            this.lstDSMH.Items.AddRange(new object[] {
            "Cấu trúc DL",
            "C_Sharp",
            "Lập trình DeskTop",
            "Python",
            "Java"});
            this.lstDSMH.Location = new System.Drawing.Point(161, 34);
            this.lstDSMH.Name = "lstDSMH";
            this.lstDSMH.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstDSMH.Size = new System.Drawing.Size(275, 149);
            this.lstDSMH.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnThoat);
            this.groupBox4.Controls.Add(this.btnLamMoi);
            this.groupBox4.Controls.Add(this.btnXemThongTin);
            this.groupBox4.Location = new System.Drawing.Point(615, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 309);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnXemThongTin
            // 
            this.btnXemThongTin.Location = new System.Drawing.Point(6, 70);
            this.btnXemThongTin.Name = "btnXemThongTin";
            this.btnXemThongTin.Size = new System.Drawing.Size(180, 53);
            this.btnXemThongTin.TabIndex = 0;
            this.btnXemThongTin.Text = "Xem thông tin";
            this.btnXemThongTin.UseVisualStyleBackColor = true;
            this.btnXemThongTin.Click += new System.EventHandler(this.btnXemThongTin_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(6, 139);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(180, 44);
            this.btnLamMoi.TabIndex = 1;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(6, 211);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(180, 37);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmThongTinSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 658);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.cboQueQuan);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmThongTinSV";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkTiengNhat;
        private System.Windows.Forms.CheckBox chkTiengAnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstDSMH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboQueQuan;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXemThongTin;
    }
}