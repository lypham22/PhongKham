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
    public class BenhNhanDAL
    {
        ConnectDB cnDB;
        public BenhNhanDAL()
        {
            cnDB = new ConnectDB();
        }

        public int ThemBenhNhan(BenhNhan bn)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaBenhNhan", bn.MaBenhNhan));
            paras.Add(new SqlParameter("@HoVaTen", bn.HoVaTen));
            paras.Add(new SqlParameter("@DiaChi", bn.DiaChi));
            paras.Add(new SqlParameter("@NamSinh", bn.NamSinh));
            paras.Add(new SqlParameter("@Para", bn.Para));
            paras.Add(new SqlParameter("@DienThoai", bn.DienThoai));
            paras.Add(new SqlParameter("@NgayDuSanh", bn.NgayDuSanh));
            paras.Add(new SqlParameter("@GhiChu", bn.GhiChu));
            try
            {
                cnDB.ExecNonQuery("spa_ThemBenhNhan", CommandType.StoredProcedure, paras, out paras);

                return 0;
            }
            catch (SqlException p)
            {

                throw p;
            }
        }

        public List<BenhNhanDS> DanhSachBenhNhan(string soDienThoai)
        {
            try
            {
                List<BenhNhanDS> list = new List<BenhNhanDS>();
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@SoDienThoai", soDienThoai));
                DataTable dr = cnDB.Execute("spa_DanhSachBenhNhan", paras);
                if (dr != null && dr.Rows.Count > 0)
                {
                    for (var i = 0; i < dr.Rows.Count; i++)
                    {
                        list.Add(new BenhNhanDS
                        {
                            MaBenhNhan = int.Parse(dr.Rows[i]["MaBenhNhan"].ToString()),
                            HoVaTen = dr.Rows[i]["HoVaTen"].ToString(),
                            NgayDuSanh = DateTime.Parse(dr.Rows[i]["NgayDuSanh"].ToString()),
                            DiaChi = dr.Rows[i]["DiaChi"].ToString(),
                            NgayTao = DateTime.Parse(dr.Rows[i]["NgayTao"].ToString())
                        });
                    }
                }

                return list;
            }
            catch (SqlException p)
            {
                throw p;
            }
        }

        public BenhNhan ChiTietBenhNhan(string maBenhNhan)
        {
            try
            {
                BenhNhan bn = new BenhNhan();
                List<SqlParameter> paras = new List<SqlParameter>();
                paras.Add(new SqlParameter("@MaBenhNhan", maBenhNhan));
                DataTable dr = cnDB.Execute("spa_ChiTietBenhNhan", paras);
                if (dr != null && dr.Rows.Count > 0)
                {
                    DataRow data = dr.Rows[0];
                    bn = new BenhNhan
                    {
                        MaBenhNhan = int.Parse(data["MaBenhNhan"].ToString()),
                        HoVaTen = data["HoVaTen"].ToString(),
                        NgayDuSanh = DateTime.Parse(data["NgayDuSanh"].ToString()),
                        NamSinh= int.Parse(data["NamSinh"].ToString()),
                        DienThoai = data["DienThoai"].ToString(),
                        Para = data["Para"].ToString(),
                        GhiChu = data["GhiChu"].ToString(),
                        DiaChi = data["DiaChi"].ToString(),
                        NgayTao = DateTime.Parse(data["NgayTao"].ToString())
                    };
                }
                return bn;
            }
            catch (SqlException p)
            {
                throw p;
            }
        }

        public bool XoaBenhNhan(string maBenhNhan)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaBenhNhan", maBenhNhan));
            try
            {
                cnDB.ExecNonQuery("spa_XoaBenhNhan", CommandType.StoredProcedure, paras, out paras);
                return true;
            }
            catch (SqlException p)
            {

                throw p;
            }
        }
    }
}
