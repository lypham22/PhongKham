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
    public partial class ThemBenhNhan : Form
    {
        BenhNhanDAL benhNhanDAL;

        public ThemBenhNhan(string maBenhNhan)
        {
            InitializeComponent();

            benhNhanDAL = new BenhNhanDAL();

            //string maBenhNhan = DanhSachBN.MaBenhNhanID;
            if (!string.IsNullOrEmpty(maBenhNhan))
            {
                LoadBenhNhan(maBenhNhan);
            }

            AnHienButton(maBenhNhan);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và Tên", "Thông báo");
                return;
            }

            if (string.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập Số Điện Thoại", "Thông báo");
                return;
            }

            BenhNhan benhNhan = new BenhNhan
            {
                MaBenhNhan = string.IsNullOrEmpty(txtHdMaBenhNhan.Text) ? 0 : int.Parse(txtHdMaBenhNhan.Text),
                HoVaTen = txtHoVaTen.Text,
                DienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text,
                NgayDuSanh = DateTime.Parse(dtNgayDuSanh.Text),
                NamSinh = int.Parse(txtNamSinh.Text),
                Para = txtPara.Text,
                GhiChu = txtGhiChu.Text
            };

            benhNhanDAL.ThemBenhNhan(benhNhan);

            MessageBox.Show("Cập nhật thành công", "Thông báo");

            this.Close();
        }

        private void LoadBenhNhan(string maBenhNhan)
        {
            BenhNhan benhNhan = benhNhanDAL.ChiTietBenhNhan(maBenhNhan);

            txtHdMaBenhNhan.Text = maBenhNhan;
            txtHoVaTen.Text = benhNhan.HoVaTen;
            txtSoDienThoai.Text = benhNhan.DienThoai;
            txtDiaChi.Text = benhNhan.DiaChi;
            dtNgayDuSanh.Text = benhNhan.NgayDuSanh.ToString();
            txtNamSinh.Text = benhNhan.NamSinh.ToString();
            txtPara.Text = benhNhan.Para;
            txtGhiChu.Text = benhNhan.GhiChu;
        }

        private void AnHienButton(string maBenhNhan)
        {
            btnThem.Text = string.IsNullOrEmpty(maBenhNhan) ? "Thêm" : "Cập nhật";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
