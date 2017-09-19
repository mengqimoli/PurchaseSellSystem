using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBCL
{
    public class DataBase
    {
        string strConn;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        public void play(string sql)
        {
            strConn = "Data Source=;Initial Catalog=FisheryInfoCollection2;Persist Security Info=True;database=dbPurchaseSellSystem;uid=茉莉;pwd=wang513901";
            conn = new SqlConnection(strConn);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
        }
        public void DB_ZSG(string sql)
        {
            play(sql);
            cmd.ExecuteNonQuery();
        }
        public string DB_C(string sql, int num)
        {
            play(sql);
            dr = cmd.ExecuteReader();
            dr.Read();
            return dr.GetString(num);
        }
        public SqlDataReader DB_Red(string sql)
        {
            play(sql);
            dr = cmd.ExecuteReader();
            return dr;
        }
        public SqlDataAdapter DB_Adp(string sql)
        {
            play(sql);
            da = new SqlDataAdapter(cmd);
            return da;
        }
        public void connClose()
        {
            conn.Close();
        }
        public void odrClose()
        {
            dr.Close();
        }
    }
}
