using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoUDWindowsForm.Entities;

namespace DemoUDWindowsForm
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            //Cau hinh cho ung dung
            CauHinh();
        }

        private void CauHinh()
        {
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            string[] row = { txtSoTaiKhoan.Text, txtHoTen.Text };
            var soTaiKhoan = new ListViewItem(row);
            lstTaiKhoan.Items.Add(soTaiKhoan);
        }
    }
}
