using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhongKhamSan.DAL
{
    public class ConnectDB
    {
        string cnstr = "";
        SqlConnection cn;
        public ConnectDB()
        {
            cnstr = ConfigurationManager.ConnectionStrings["PhongKhamDB"].ConnectionString;
            cn = new SqlConnection(cnstr);
        }
        private void Connect()
        {
            try
            {
                if (cn != null && cn.State != ConnectionState.Open)
                    cn.Open();
            }
            catch (SqlException p)
            {

                throw p;
            }
        }
        private void Disconnect()
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }
        public DataTable Execute(string sql, List<SqlParameter> paras)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                SqlDataAdapter adp = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                dt = ds.Tables[0];
                return dt;
            }
            catch
            {
                return dt;
            }
        }
        public void ExecNonQuery(string sql, CommandType type, List<SqlParameter> paras, out List<SqlParameter> outputParams )
        {
            try
            {
                outputParams = new List<SqlParameter>();
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                if (paras != null)
                {

                    foreach (SqlParameter para in paras)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                cmd.CommandType = type;
                cmd.ExecuteNonQuery();
                SqlParameter outParam = null;
                foreach (SqlParameter param in paras)
                {
                    if (param.Direction != ParameterDirection.Output) continue;

                    // get output values and set to parameter value
                    outParam = param;
                    outputParams.Add(outParam);
                }
            }
            catch (SqlException p)
            {
                throw p;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
