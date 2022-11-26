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
    public partial class PrintPhieuKham : Form
    {
        readonly BenhNhan _benhNhan;

        readonly ThongTinKham _thongTinKham;
        public PrintPhieuKham(BenhNhan benhNhan, ThongTinKham thongTinKham)
        {
            _benhNhan = benhNhan;
            _thongTinKham = thongTinKham;
            InitializeComponent();
        }

        private void PrintPhieuKham_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pHoVaTen", _benhNhan.HoVaTen),
                new Microsoft.Reporting.WinForms.ReportParameter("pNamSinh", _benhNhan.NamSinh.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pDiaChi", _benhNhan.DiaChi),
                new Microsoft.Reporting.WinForms.ReportParameter("pDienThoai", _benhNhan.DienThoai),
                new Microsoft.Reporting.WinForms.ReportParameter("pPara", _benhNhan.Para),
                new Microsoft.Reporting.WinForms.ReportParameter("pGhiChu", _benhNhan.GhiChu),
                new Microsoft.Reporting.WinForms.ReportParameter("pNgayDuSanh", _benhNhan.NgayDuSanh.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pTuoiThai", _benhNhan.TuoiThai),
                new Microsoft.Reporting.WinForms.ReportParameter("pLyDoKham", _thongTinKham.LyDoKham),
                new Microsoft.Reporting.WinForms.ReportParameter("pTienSu", _thongTinKham.TienSu),
                 new Microsoft.Reporting.WinForms.ReportParameter("pBenhSu", _thongTinKham.BenhSu),
                new Microsoft.Reporting.WinForms.ReportParameter("pMach", _thongTinKham.Mach.HasValue ? _thongTinKham.Mach.Value.ToString() : string.Empty),
                 new Microsoft.Reporting.WinForms.ReportParameter("pHuyetAp", _thongTinKham.HuyetAp),
                new Microsoft.Reporting.WinForms.ReportParameter("pNhietDo", _thongTinKham.NhietDo.HasValue ? _thongTinKham.NhietDo.Value.ToString() : string.Empty),
                 new Microsoft.Reporting.WinForms.ReportParameter("pCanNang", _thongTinKham.CanNang.HasValue ?  _thongTinKham.CanNang.Value.ToString() : string.Empty),
                new Microsoft.Reporting.WinForms.ReportParameter("pChieuCao", _thongTinKham.ChieuCao.HasValue ? _thongTinKham.ChieuCao.Value.ToString() : string.Empty),
                 new Microsoft.Reporting.WinForms.ReportParameter("pBMI", _thongTinKham.BMI.HasValue ? _thongTinKham.BMI.Value.ToString() : string.Empty),
                new Microsoft.Reporting.WinForms.ReportParameter("pTongTrang", _thongTinKham.TongTrang),
                 new Microsoft.Reporting.WinForms.ReportParameter("pTim", _thongTinKham.Tim),
                new Microsoft.Reporting.WinForms.ReportParameter("pPhoi", _thongTinKham.Phoi),
                 new Microsoft.Reporting.WinForms.ReportParameter("pBung", _thongTinKham.Bung),
                new Microsoft.Reporting.WinForms.ReportParameter("pBeCaoTuCung", _thongTinKham.BeCaoTuCung.HasValue ? _thongTinKham.BeCaoTuCung.Value.ToString() : string.Empty),
                 new Microsoft.Reporting.WinForms.ReportParameter("pTimThai1", _thongTinKham.TimThai1.HasValue ? _thongTinKham.TimThai1.Value.ToString() : string.Empty),
                new Microsoft.Reporting.WinForms.ReportParameter("pTimThai2", _thongTinKham.TimThai2.HasValue ? _thongTinKham.TimThai2.Value.ToString() : string.Empty),
                new Microsoft.Reporting.WinForms.ReportParameter("pConGo", _thongTinKham.ConGo.HasValue ? _thongTinKham.ConGo.Value.ToString() : string.Empty),
                new Microsoft.Reporting.WinForms.ReportParameter("pAmHo", _thongTinKham.AmHo),
                new Microsoft.Reporting.WinForms.ReportParameter("pAmDao", _thongTinKham.AmDao),
                new Microsoft.Reporting.WinForms.ReportParameter("pCoTuCung", _thongTinKham.CoTuCung),
                new Microsoft.Reporting.WinForms.ReportParameter("pNgoi", _thongTinKham.Ngoi),
                new Microsoft.Reporting.WinForms.ReportParameter("pNuocOi", _thongTinKham.NuocOi),
                new Microsoft.Reporting.WinForms.ReportParameter("pKhungChau", _thongTinKham.KhungChau),
                new Microsoft.Reporting.WinForms.ReportParameter("pYeuToNguyCo", _thongTinKham.YeuToNguyCo),
                new Microsoft.Reporting.WinForms.ReportParameter("pCacChiDinhCLS", _thongTinKham.CacChiDinhCLS),
                new Microsoft.Reporting.WinForms.ReportParameter("pChuanDoan", _thongTinKham.ChuanDoan),
                new Microsoft.Reporting.WinForms.ReportParameter("pHuongXuLy", _thongTinKham.HuongXuLy),
                new Microsoft.Reporting.WinForms.ReportParameter("pTaiKham", _thongTinKham.TaiKham),
                new Microsoft.Reporting.WinForms.ReportParameter("pDanDo", _thongTinKham.DanDo),
            };

            this.reportViewer.LocalReport.SetParameters(p);
            this.reportViewer.RefreshReport();
        }
    }
}
