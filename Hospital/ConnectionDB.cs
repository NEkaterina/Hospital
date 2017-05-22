using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
   public class ConnectionDB
    {
        public static SqlConnection sql = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\DB(kur)\MedDB.mdf;Integrated Security=True;Connect Timeout=30");


        static ConnectionDB()
        {
        }
        
        public static void queryExecute(string s)
        {
            sql.Open();

            SqlCommand sc = new SqlCommand(s, sql);

            sc.ExecuteNonQuery();
            sql.Close();
        }

        public static DataTable getResult(string s)
        {

            sql.Open();
            SqlCommand sc = new SqlCommand(s, sql);

            SqlDataReader sdr = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);

            sdr.Close();

            sql.Close();

            return dt;
        }
       

        }
}

