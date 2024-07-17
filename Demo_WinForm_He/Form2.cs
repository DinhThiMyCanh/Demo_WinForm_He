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
    public partial class frmThongTinSV : Form
    {
        public frmThongTinSV()
        {
            InitializeComponent();
        }

        private void btnXemThongTin_Click(object sender, EventArgs e)
        {
            string ht = txtHoTen.Text;
            //C1: string ns = dtpNgaySinh.Text;
            string ns = dtpNgaySinh.Value.ToString();
            string gt = rdNam.Checked == true ? "Nam" : "Nữ";

            string nn = "";
            if (chkTiengAnh.Checked == true)
                nn = chkTiengAnh.Text;
            if (chkTiengNhat.Checked == true)
                nn = nn + " " + chkTiengNhat.Text;

            string qq = cboQueQuan.SelectedItem.ToString();
            string dsmh = "";
            foreach (var mh in lstDSMH.SelectedItems)
                dsmh = dsmh + mh +"\n";

            string st = @"Họ tên:" + ht + 
                "\n" + "Ngày sinh:" + ns 
                + "\n" + "Giới tính" + gt +
                "\n" + "Ngoại ngữ:" + nn + 
                "\n" + "Quê quán:" + qq + 
                "\n" + "Danh sách môn học:" + dsmh;
            MessageBox.Show(st);


        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Clear();
            txtHoTen.Focus();
            dtpNgaySinh.Value = DateTime.Now;

            if (rdNam.Checked == false)
                rdNam.Checked = true;

            if (chkTiengAnh.Checked == true)
                chkTiengAnh.Checked = false;
            if (chkTiengNhat.Checked == true)
                chkTiengNhat.Checked = false;

            cboQueQuan.SelectedIndex = 0;
            lstDSMH.ClearSelected(); //Hủy mục đang chọn

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
