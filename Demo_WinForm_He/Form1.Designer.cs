
namespace Demo_WinForm_He
{
    partial class frmMayTinh
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(176, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH MÁY TÍNH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(196, 77);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(246, 39);
            this.txtSo1.TabIndex = 4;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(196, 134);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(246, 39);
            this.txtSo2.TabIndex = 5;
            // 
            // txtKQ
            // 
            this.txtKQ.Enabled = false;
            this.txtKQ.Location = new System.Drawing.Point(196, 186);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(246, 39);
            this.txtKQ.TabIndex = 6;
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(78, 267);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(116, 40);
            this.btnCong.TabIndex = 7;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(210, 267);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(111, 37);
            this.btntru.TabIndex = 8;
            this.btntru.Text = "Trừ";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(337, 267);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(105, 35);
            this.btnNhan.TabIndex = 9;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(462, 267);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(105, 35);
            this.btnChia.TabIndex = 10;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(175, 327);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(146, 36);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(337, 328);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(105, 35);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMayTinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 424);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMayTinh";
            this.Text = "Các ứng dụng cơ bản";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThoat;
    }
}

