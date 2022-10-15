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
                new Microsoft.Reporting.WinForms.ReportParameter("pDiaChi", _benhNhan.DiaChi),
                new Microsoft.Reporting.WinForms.ReportParameter("pPara", _benhNhan.Para),
            };

            this.reportViewer.LocalReport.SetParameters(p);
            this.reportViewer.RefreshReport();
        }
    }
}
