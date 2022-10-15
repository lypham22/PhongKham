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
    public class ThongTinKhamDAL
    {
        ConnectDB cnDB;
        public ThongTinKhamDAL()
        {
            cnDB = new ConnectDB();
        }

        public int LuuThongTinKham(ThongTinKham ttKham)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            List<SqlParameter> outParas = new List<SqlParameter>();
            paras.Add(new SqlParameter("@MaBenhNhan", ttKham.MaBenhNhan));
            paras.Add(new SqlParameter("@MaThongTinKham", ttKham.MaThongTinKham));
            paras.Add(new SqlParameter("@LyDoKham", ttKham.LyDoKham));
            paras.Add(new SqlParameter("@TienSu", ttKham.TienSu));
            paras.Add(new SqlParameter("@BenhSu", ttKham.BenhSu));
            paras.Add(new SqlParameter("@Mach", ttKham.Mach));
            paras.Add(new SqlParameter("@HuyetAp", ttKham.HuyetAp));
            paras.Add(new SqlParameter("@NhietDo", ttKham.NhietDo));
            paras.Add(new SqlParameter("@CanNang", ttKham.CanNang));
            paras.Add(new SqlParameter("@ChieuCao", ttKham.ChieuCao));
            paras.Add(new SqlParameter("@BMI", ttKham.BMI));
            paras.Add(new SqlParameter("@TongTrang", ttKham.TongTrang));
            paras.Add(new SqlParameter("@Tim", ttKham.Tim));
            paras.Add(new SqlParameter("@Phoi", ttKham.Phoi));
            paras.Add(new SqlParameter("@Bung", ttKham.Bung));
            paras.Add(new SqlParameter("@BeCaoTuCung", ttKham.BeCaoTuCung));
            paras.Add(new SqlParameter("@TimThai1", ttKham.TimThai1));
            paras.Add(new SqlParameter("@TimThai2", ttKham.TimThai2));
            paras.Add(new SqlParameter("@ConGo", ttKham.ConGo));
            paras.Add(new SqlParameter("@AmHo", ttKham.AmHo));
            paras.Add(new SqlParameter("@AmDao", ttKham.AmDao));
            paras.Add(new SqlParameter("@CoTuCung", ttKham.CoTuCung));
            paras.Add(new SqlParameter("@Ngoi", ttKham.Ngoi));
            paras.Add(new SqlParameter("@NuocOi", ttKham.NuocOi));
            paras.Add(new SqlParameter("@KhungChau", ttKham.KhungChau));
            paras.Add(new SqlParameter("@YeuToNguyCo", ttKham.YeuToNguyCo));
            paras.Add(new SqlParameter("@CacChiDinhCLS", ttKham.CacChiDinhCLS));
            paras.Add(new SqlParameter("@ChuanDoan", ttKham.ChuanDoan));
            paras.Add(new SqlParameter("@HuongXuLy", ttKham.HuongXuLy));
            paras.Add(new SqlParameter("@TaiKham", ttKham.TaiKham));
            paras.Add(new SqlParameter("@DanDo", ttKham.DanDo));

            SqlParameter outPutVal = new SqlParameter("@MaTTKham", SqlDbType.Int);
            outPutVal.Direction = ParameterDirection.Output;

            paras.Add(outPutVal);

            cnDB.ExecNonQuery("spa_LuuThongTinKham", CommandType.StoredProcedure, paras, out outParas);

            return int.Parse(outParas[0].Value.ToString());
        }
    }
}
