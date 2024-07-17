
namespace Demo_WinForm_He
{
    partial class frmMain
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
            this.btnMayTinh = new System.Windows.Forms.Button();
            this.btnTTSV = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMayTinh
            // 
            this.btnMayTinh.Location = new System.Drawing.Point(83, 105);
            this.btnMayTinh.Name = "btnMayTinh";
            this.btnMayTinh.Size = new System.Drawing.Size(180, 82);
            this.btnMayTinh.TabIndex = 0;
            this.btnMayTinh.Text = "Máy tính";
            this.btnMayTinh.UseVisualStyleBackColor = true;
            this.btnMayTinh.Click += new System.EventHandler(this.btnMayTinh_Click);
            // 
            // btnTTSV
            // 
            this.btnTTSV.Location = new System.Drawing.Point(298, 105);
            this.btnTTSV.Name = "btnTTSV";
            this.btnTTSV.Size = new System.Drawing.Size(197, 82);
            this.btnTTSV.TabIndex = 1;
            this.btnTTSV.Text = "Thông tin SV";
            this.btnTTSV.UseVisualStyleBackColor = true;
            this.btnTTSV.Click += new System.EventHandler(this.btnTTSV_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "CHƯƠNG TRÌNH DEMO WINFROM";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 281);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTTSV);
            this.Controls.Add(this.btnMayTinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmMain";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMayTinh;
        private System.Windows.Forms.Button btnTTSV;
        private System.Windows.Forms.Label label1;
    }
}