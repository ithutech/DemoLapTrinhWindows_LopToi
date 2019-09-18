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
    public partial class frmDangKyMonHoc : Form
    {
        List<ChuyenNganh> dsChuyenNganh;
        List<MonHoc> dsMonHoc;
        List<ChuyenNganhMonHoc> dsChuyenNganhMonHoc;

        public frmDangKyMonHoc()
        {
            InitializeComponent();
            KhoiTaoGiaTri();
            KhoiTaoChonLua();
        }

        private void KhoiTaoChonLua()
        {
            try
            {
                cbxChuyenNganh.DataSource = dsChuyenNganh;
                cbxChuyenNganh.DisplayMember = "Ten";
                cbxChuyenNganh.ValueMember = "Ma";
                cbxChuyenNganh.SelectedIndex = -1;
            }
            catch (Exception exc)
            {
                Console.Write(exc.Message);
            }
            lstDanhSachMon.Clear();
        }

        private void KhoiTaoGiaTri()
        {
            dsChuyenNganh = new List<ChuyenNganh>();
            dsMonHoc = new List<MonHoc>();
            dsChuyenNganhMonHoc = new List<ChuyenNganhMonHoc>();

            dsChuyenNganh.Add(new ChuyenNganh()
            {
                Ma = 1,
                Ten = "Cong nghe phan mem"
            });
            dsChuyenNganh.Add(new ChuyenNganh()
            {
                Ma = 2,
                Ten = "He thong thong tin"
            });
            dsMonHoc.Add(new MonHoc()
            {
                Ma = 1,
                Ten = "Co so Du Lieu"
            });
            dsMonHoc.Add(new MonHoc()
            {
                Ma = 2,
                Ten = "Lap Trinh Web"
            });
            dsMonHoc.Add(new MonHoc()
            {
                Ma = 3,
                Ten = "Kiem thu phan mem"
            });
            //chuyen nganh - mon hoc
            dsChuyenNganhMonHoc.Add(new ChuyenNganhMonHoc()
            {
                Ma = 1,
                MaChuyenNganh = 1,
                MaMonHoc = 1
            });
            dsChuyenNganhMonHoc.Add(new ChuyenNganhMonHoc()
            {
                Ma = 2,
                MaChuyenNganh = 1,
                MaMonHoc = 2
            });
            dsChuyenNganhMonHoc.Add(new ChuyenNganhMonHoc()
            {
                Ma = 3,
                MaChuyenNganh = 2,
                MaMonHoc = 1
            });
            dsChuyenNganhMonHoc.Add(new ChuyenNganhMonHoc()
            {
                Ma = 4,
                MaChuyenNganh = 2,
                MaMonHoc = 3
            });
        }

        private void CbxChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //gia tri chuyen nganh lua chon thay doi
            //b1: lay ma chuyen nganh duoc lua chon
            int maChuyenNganh = ((ChuyenNganh)cbxChuyenNganh.SelectedItem).Ma;
            //b2: truy van cac gia tri mon hoc cua ma chuyen nganh b1
            var danhSachChon = dsChuyenNganhMonHoc.Where(m => m.MaChuyenNganh == maChuyenNganh).Select(m => m.MaMonHoc).ToList();
            //b3. Dua theo id cua mon hoc se lay ra ten mon hoc
            lstDanhSachMon.Clear();
            foreach (var item in dsMonHoc)
            {
                if (danhSachChon.Contains(item.Ma))
                {
                    lstDanhSachMon.Items.Add(item.Ten);
                }
            }

        }
    }
}
