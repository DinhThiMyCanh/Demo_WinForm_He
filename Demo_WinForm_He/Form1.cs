using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_WinForm_He
{
    public partial class frmMayTinh : Form
    {
        public frmMayTinh()
        {
            InitializeComponent();
        }

        //Cộng 2 số nguyên
        private void btnCong_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSo1.Text);
            int so2 = int.Parse(txtSo2.Text);
            int kq = so1 + so2;
            txtKQ.Text = kq.ToString();
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSo1.Text);
            int so2 = int.Parse(txtSo2.Text);
            int kq = so1 - so2;
            txtKQ.Text = kq.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSo1.Text);
            int so2 = int.Parse(txtSo2.Text);
            int kq = so1 * so2;
            txtKQ.Text = kq.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int so1 = int.Parse(txtSo1.Text);
            int so2 = int.Parse(txtSo2.Text);
            float kq = (float) so1 / so2;
            txtKQ.Text = kq.ToString();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            txtKQ.Clear();
            txtSo1.Focus(); //Đưa con trỏ vào ô số 1
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
