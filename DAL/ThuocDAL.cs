using PhongKhamSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKhamSan.DAL
{
    public class ThuocDAL : BaseDAL
    {
        public int ThemThuoc(Thuoc thuoc)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaThuoc", thuoc.MaThuoc));
            paras.Add(new SqlParameter("@TenThuoc", thuoc.TenThuoc));
            paras.Add(new SqlParameter("@DonGia", thuoc.DonGia));
            paras.Add(new SqlParameter("@SoLuong", thuoc.SoLuong));
            paras.Add(new SqlParameter("@HanSuDung", thuoc.HanSuDung));

            try
            {
                cnDB.ExecNonQuery("spa_ThemThuoc", CommandType.StoredProcedure, paras, out paras);

                return 0;
            }
            catch (SqlException p)
            {

                throw p;
            }
        }
    }
}
