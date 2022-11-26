using PhongKhamSan.DAL;
using PhongKhamSan.DTO;
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
    public partial class NhapThuoc : Form
    {
        ThuocDAL thuocDAL;
        public NhapThuoc()
        {
            InitializeComponent();

            thuocDAL = new ThuocDAL();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Thuoc thuoc = new Thuoc
            {
                MaThuoc = int.Parse(txtMaThuoc.Text),
                TenThuoc = txtTenThuoc.Text,
                DonGia = int.Parse(txtDonGia.Text),
                SoLuong = int.Parse(txtSoLuong.Text),
                HanSuDung = DateTime.Parse(dtHanSuDung.Text)
            };

            thuocDAL.ThemThuoc(thuoc);

            MessageBox.Show("Cập nhật thành công", "Thông báo");

            this.Close();
        }
    }
}
