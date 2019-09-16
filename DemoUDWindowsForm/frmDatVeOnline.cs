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
    public partial class frmDatVeOnline : Form
    {
        List<Button> danhSachChon = new List<Button>();

        public frmDatVeOnline()
        {
            InitializeComponent();
        }

        private void Button18_Click(object sender, EventArgs e)
        {

        }

        private void btnChonVe_Click(object sender, EventArgs e)
        {
            Button btnChon = (Button)sender;
           
            //kiem tra nut chon
            //neu la mau trang thi doi thanh mau xanh hoac nguoc lai
            if (btnChon.BackColor == Color.White)
            {
                if(!danhSachChon.Contains(btnChon))
                    danhSachChon.Add(btnChon);
                btnChon.BackColor = Color.Blue;
            }
            else if (btnChon.BackColor == Color.Blue)
            {
                danhSachChon.Remove(btnChon);
                btnChon.BackColor = Color.White;
            }
            else
                MessageBox.Show("Vi tri nay da duoc ban!");   
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
            double thanhTien = 0;
            foreach (Button ve in danhSachChon)
            {
                int item = int.Parse(ve.Text);
                if (item <= 5)
                {
                    thanhTien += 5000;
                }
                else if (item > 5 && item <= 10)
                    thanhTien += 6500;
                else
                    thanhTien += 8000;
                ve.BackColor = Color.Yellow;
            }
            txtThanhTien.Text = thanhTien.ToString();

        }
    }
}
