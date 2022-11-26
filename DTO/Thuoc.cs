using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKhamSan.DTO
{
    public class Thuoc
    {
        public int MaThuoc { get; set; }

        public string TenThuoc { get; set; }

        public int DonGia { get; set; }

        public int SoLuong { get; set; }

        public DateTime HanSuDung { get; set; }
    }
}
