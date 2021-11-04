using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSI.DAO
{
    class DB_Connection
    {
        SqlConnection connection;
        SqlCommand cmd;

        string url_con = "Data Source=DESKTOP-QFH50D0\\SQLEXPRESS;Initial Catalog=DSIBD10;Integrated Security=True";
        SqlDataReader reader;
        //string url_con = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        
        private void Connect(string sql)
        {
            connection = new SqlConnection(url_con);
            cmd = new SqlCommand(sql, connection);
            cmd.CommandTimeout = 60;
        }

        private void Disconnect()
        {
            connection.Close();
        }

        public DataTable Query(string sql)
        {
            Connect(sql);

            DataTable res = new DataTable();
            try
            {
                connection.Open();
                reader = cmd.ExecuteReader();

                res.Load(reader);
                Disconnect();
                return res;
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public void Del_Upd(string sql)
        {
            Connect(sql);
            try
            {
                connection.Open();
                cmd.ExecuteReader();
                Disconnect();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
