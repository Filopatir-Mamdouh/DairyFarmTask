using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyFarmTask
{
    internal class DatabaseConnection
    {
        private SqlConnection con;
        private SqlCommand cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private String Constr;
        public DatabaseConnection()
        {
            Constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nour\Documents\DairyFarmDb.mdf;Integrated Security=True;Connect Timeout=30";
            con = new SqlConnection(Constr);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public DataTable GetData(String Query)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter(Query, Constr);
            sda.Fill(dt);
            return dt;
        }

        public int SetData(String Query)
        {
            int cnt = 0;
            if ((con.State == ConnectionState.Closed))
            {
                con.Open();
            }
            cmd.CommandText = Query;
            cnt = cmd.ExecuteNonQuery();
            con.Close();
            return cnt;
        }
    }
}
