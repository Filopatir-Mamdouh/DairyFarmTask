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
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nour\Documents\DairyFarmDb.mdf;Integrated Security=True;Connect Timeout=30");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

    }
}
