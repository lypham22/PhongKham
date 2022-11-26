using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKhamSan.DTO
{
    public class BenhNhan
    {
        public int MaBenhNhan { get; set; }

        public string HoVaTen { get; set; }

        public string DiaChi { get; set; }

        public int NamSinh { get; set; }

        public string Para { get; set; }

        public string DienThoai { get; set; }

        public DateTime NgayDuSanh { get; set; }

        public string TuoiThai { get; set; }

        public string GhiChu { get; set; }
        public DateTime NgayTao { get; set; }

        public int GioiTinh { get; set; }

    }

    public class BenhNhanDS
    {
        public int MaBenhNhan { get; set; }

        public string HoVaTen { get; set; }

        public string DiaChi { get; set; }

        public DateTime NgayDuSanh { get; set; }

        public DateTime NgayTao { get; set; }
    }
}
