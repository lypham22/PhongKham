using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongKhamSan
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void mLapPhieuKham_Click(object sender, EventArgs e)
        {
            PhieuKham phieuKham = new PhieuKham();
            phieuKham.Show();
        }

        private void menuDSBN_Click(object sender, EventArgs e)
        {
            DanhSachBN dsBN = new DanhSachBN();
            dsBN.Show();
        }

        private void menuThemBenhNhan_Click(object sender, EventArgs e)
        {
            ThemBenhNhan themBenhNhan = new ThemBenhNhan(string.Empty);
            themBenhNhan.Show();

        }

        private void menuNhapThuoc_Click(object sender, EventArgs e)
        {
            NhapThuoc nhapThuoc = new NhapThuoc();
            nhapThuoc.Show();
        }
    }
}
