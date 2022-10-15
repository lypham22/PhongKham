using PhongKhamSan.DAL;
using PhongKhamSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhongKhamSan
{
    public partial class PhieuKham : Form
    {
        BenhNhanDAL benhNhanDAL;
        ThongTinKhamDAL thongTinKhamDAL;

        public PhieuKham(string maBenhNhan = "")
        {
            InitializeComponent();

            benhNhanDAL = new BenhNhanDAL();
            thongTinKhamDAL = new ThongTinKhamDAL();

            LoadDanhSachBenhNhan();

            if (!string.IsNullOrEmpty(maBenhNhan))
            {
                LoadBenhNhan(maBenhNhan);
            }
        }

        private void LoadBenhNhan(string maBenhNhan)
        {
            BenhNhan benhNhan = benhNhanDAL.ChiTietBenhNhan(maBenhNhan);

            cbMaBenhNhan.Text = maBenhNhan;
            txtHoVaTen.Text = benhNhan.HoVaTen;
            txtSoDienThoai.Text = benhNhan.DienThoai;
            txtDiaChi.Text = benhNhan.DiaChi;
            dtNgayDuSanh.Text = benhNhan.NgayDuSanh.ToString();
            txtNamSinh.Text = benhNhan.NamSinh.ToString();
            txtPara.Text = benhNhan.Para;
            txtGhiChu.Text = benhNhan.GhiChu;
        }

        private void LoadDanhSachBenhNhan()
        {
            List<BenhNhanDS> listBN = benhNhanDAL.DanhSachBenhNhan(string.Empty);
            cbMaBenhNhan.DataSource = listBN;
            cbMaBenhNhan.DisplayMember = "MaBenhNhan";
            cbMaBenhNhan.ValueMember = "MaBenhNhan";

            //cbMaBenhNhan.Items.Insert(0, "Chọn Mã Bệnh Nhân");
        }

        private void cbMaBenhNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            BenhNhanDS benhNhan = (BenhNhanDS)cbMaBenhNhan.SelectedValue;
            string maBenhNhan = benhNhan.MaBenhNhan.ToString();

            LoadBenhNhan(maBenhNhan);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Cap Nhat thong tin Benh Nhan
            LuuBenhNhan();

            // Luu thong tin kham
            LuuThongTinKham();
        }

        private void LuuBenhNhan()
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
                MaBenhNhan = int.Parse(cbMaBenhNhan.Text),
                HoVaTen = txtHoVaTen.Text,
                DienThoai = txtSoDienThoai.Text,
                DiaChi = txtDiaChi.Text,
                NgayDuSanh = DateTime.Parse(dtNgayDuSanh.Text),
                NamSinh = int.Parse(txtNamSinh.Text),
                Para = txtPara.Text,
                GhiChu = txtGhiChu.Text
            };

            benhNhanDAL.ThemBenhNhan(benhNhan);
        }

        private void LuuThongTinKham()
        {
            ThongTinKham ttKham = new ThongTinKham 
            {
                MaBenhNhan = double.Parse(cbMaBenhNhan.Text),
                MaThongTinKham = string.IsNullOrEmpty(txtMaThongTinKham.Text) ? 0 : int.Parse(txtMaThongTinKham.Text),
                LyDoKham = txtLyDoKham.Text,
                TienSu = txtTienSu.Text,
                BenhSu = txtBenhSu.Text,
                Mach = string.IsNullOrEmpty(txtMach.Text) ? default(decimal?) : decimal.Parse(txtMach.Text),
                HuyetAp = txtHuyetAp.Text,
                NhietDo = string.IsNullOrEmpty(txtNhietDo.Text) ? default(decimal?) : decimal.Parse(txtNhietDo.Text),
                CanNang = string.IsNullOrEmpty(txtCanNang.Text) ? default(decimal?) : decimal.Parse(txtCanNang.Text),
                ChieuCao = string.IsNullOrEmpty(txtChieuCao.Text) ? default(decimal?) : decimal.Parse(txtChieuCao.Text),
                BMI = string.IsNullOrEmpty(txtBMI.Text) ? default(decimal?) : decimal.Parse(txtBMI.Text),
                TongTrang = txtTongTrang.Text,
                Tim = txtTim.Text,
                Phoi = txtPhoi.Text,
                Bung = txtBung.Text,
                BeCaoTuCung = string.IsNullOrEmpty(txtBeCaoTuCung.Text) ? default(decimal?) : decimal.Parse(txtBeCaoTuCung.Text),
                TimThai1 = string.IsNullOrEmpty(txtTimThai.Text) ? default(decimal?) : decimal.Parse(txtTimThai.Text),
                TimThai2 = string.IsNullOrEmpty(txtTimThai2.Text) ? default(decimal?) : decimal.Parse(txtTimThai2.Text),
                ConGo = string.IsNullOrEmpty(txtConGo.Text) ? default(decimal?) : decimal.Parse(txtConGo.Text),
                AmHo = txtAmHo.Text,
                AmDao = txtAmDao.Text,
                CoTuCung = txtCoTuCung.Text,
                Ngoi = txtNgoi.Text,
                NuocOi = txtOi.Text,
                KhungChau = txtKhungChau.Text,
                YeuToNguyCo = txtYeuToNguyCo.Text,
                CacChiDinhCLS = txtChiDinhCLS.Text,
                ChuanDoan = txtChuanDoan.Text,
                HuongXuLy = txtHuongXuLy.Text,
                TaiKham = txtTaiKham.Text,
                DanDo = txtDanDo.Text,
            };

            int maTTKkham = thongTinKhamDAL.LuuThongTinKham(ttKham);
            txtMaThongTinKham.Text = maTTKkham.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Cap Nhat thong tin Benh Nhan 
            LuuBenhNhan();

            // Luu thong tin kham
            LuuThongTinKham();

            BenhNhan benhNhan = benhNhanDAL.ChiTietBenhNhan(cbMaBenhNhan.Text);

            using(PrintPhieuKham frm = new PrintPhieuKham(benhNhan, new ThongTinKham()))
            {
                frm.ShowDialog();
            }
        }
    }
}
