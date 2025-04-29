using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTH6_1
{
    internal class DatabaseConnection
    {
        string connString = "Data Source=YANGLAPTOP\\YANGSQLSERVER;Initial Catalog=NhanVien;Integrated Security=True";
        SqlConnection conn = null;
        public SqlConnection getConnection()
        {
            try
            {
                if (conn == null)
                {
                    conn = new SqlConnection(connString);
                    conn.Open();
                }


            }
            catch
            {
                throw;
            }

            return conn;
        }
        public void closeConnection(SqlConnection conn)
        {
            if (conn != null)
                conn.Close();
        }
    }
}
