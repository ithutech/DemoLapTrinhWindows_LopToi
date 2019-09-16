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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnPhepTinh_Click(object sender, EventArgs e)
        {
            Button btnPhepTinh = (Button)sender;
            string tenPhepTinh = btnPhepTinh.Name;
            float soA = float.Parse(txtSoA.Text);
            float soB = float.Parse(txtSoB.Text);
            float ketQua = 0;
            switch (tenPhepTinh)
            {
                case "btnDauCong":
                    ketQua = soA + soB;
                    break;
                case "btnDauTru":
                    ketQua = soA - soB;
                    break;
                case "btnDauChia":
                    ketQua = soA / soB;
                    break;
                case "btnDauNhan":
                    ketQua = soA * soB;
                    break;
                default:
                    break;
            }
            this.txtKetQua.Text = ketQua.ToString();
        }
    }
}
