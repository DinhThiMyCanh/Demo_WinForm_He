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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnMayTinh_Click(object sender, EventArgs e)
        {
            frmMayTinh f = new frmMayTinh();
            f.Show();
            
        }

        private void btnTTSV_Click(object sender, EventArgs e)
        {
            frmThongTinSV f = new frmThongTinSV();
            f.Show();
           
        }
    }
}
