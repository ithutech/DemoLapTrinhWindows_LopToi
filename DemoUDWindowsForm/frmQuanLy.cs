using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoUDWindowsForm
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void BánVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatVeOnline frm = new frmDatVeOnline();
            if (ShowActive(frm) == false)
            {
                frm.MdiParent = this;
                frm.Show();
            }
            
        }

        private bool ShowActive(Form frm)
        {
            foreach (var childForm in this.MdiChildren)
            {
                if (frm.Name == childForm.Name)
                {
                    childForm.Activate();
                    return true;
                }
            }
            return false;
        }

        private void QuảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyTaiKhoan frm = new frmQuanLyTaiKhoan();
            if (ShowActive(frm) == false)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
