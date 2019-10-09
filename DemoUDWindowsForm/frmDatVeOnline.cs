using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoUDWindowsForm.DataAccessLayer;

namespace DemoUDWindowsForm
{
    public partial class frmDatVeOnline : Form
    {
        List<Button> danhSachChon = new List<Button>();
        BanVeOnlineEntities dbContext;

        public frmDatVeOnline()
        {
            InitializeComponent();
            dbContext = new BanVeOnlineEntities();
            CaiDatLaiGiaoDien();
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
            //Thuc hien hanh dong tinh tien
            TinhTien();

        }

        private void TinhTien()
        {
            //Entity Framework

            double tongTien = 0;
            foreach (var ve in danhSachChon)
            {
                int soGhe = int.Parse(ve.Text);
                tongTien += (double)dbContext.Ghes.Where(x => x.SoGhe == soGhe).FirstOrDefault().HangGhe.GiaVe;
            }
            this.txtThanhTien.Text = tongTien.ToString();
        }

        private void BtnChon_Click(object sender, EventArgs e)
        {
           
            //b1. Tao thong tin khach hang + luu khach hang
            KhachHang kh = new KhachHang();
            kh.TenKH = txtHoTen.Text;
            dbContext.KhachHangs.Add(kh);
            //b2. Tao hoa don 
            HoaDon hd = new HoaDon();
            hd.MaKH = kh.MaKH;
            hd.Ngay = DateTime.Now;
            dbContext.HoaDons.Add(hd);
            //b3. Tao chi tiet hoa don va cap nhat trang thai nut
            ChiTietHoaDon cthd;
            foreach (var ve in danhSachChon)
            {
                cthd = new ChiTietHoaDon();
                //lamda expression
                int soGhe = int.Parse(ve.Text);
                cthd.MaGhe = dbContext.Ghes.Where(a => a.SoGhe == soGhe).FirstOrDefault().MaGhe;
                cthd.MaHD = hd.MaHD;
                dbContext.ChiTietHoaDons.Add(cthd);
            }
            dbContext.SaveChanges();
            //Cai dat lai giao dien
            CaiDatLaiGiaoDien();
        }

        private void CaiDatLaiGiaoDien()
        {
            //b1. Cai dat trong ten khach hang
            txtHoTen.Text = "";
            //b2. Cai dat trong tong tien
            txtThanhTien.Text = "0";
            //b3. Cai dat cac nut da duoc chon
            //b3.1. Lay ra danh sach cac SoGhe da duoc ban
            var danhSachGheDaBan = (from s in dbContext.ChiTietHoaDons
                                    select s.Ghe.SoGhe).ToList();
            //b3.2 Cai dat tat ca nhung Nut (button) co soGhe nam trong 
            //danSachGheDaBan thi chuyen thanh mau vang
            foreach (var button in this.Controls.OfType<Button>())
            {
                int text;

                if(int.TryParse(button.Text, out text))
                {
                    if (danhSachGheDaBan.Contains(text))
                    {
                        button.BackColor = Color.Yellow;
                    }
                }
                
            }
        }
    }
}
