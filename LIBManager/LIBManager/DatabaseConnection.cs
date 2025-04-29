using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBManager
{
    internal class DatabaseConnection
    {
        string connectionString = @"Data Source=YANGLAPTOP\YANGSQLSERVER;Initial Catalog=Library;Integrated Security=True";
        SqlConnection conn = null;
        public SqlConnection getConnection()
        {
            try
            {
                if (conn == null || conn.State == System.Data.ConnectionState.Closed)

                {
                    this.conn = new SqlConnection(connectionString);
                    conn.Open();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Lỗi khi kết nối cơ sở dữ liệu: " + ex.Message);

            }
            return conn;
        }
        public void closeConnection(SqlConnection conn)
        {
           if(conn!=null || conn.State != System.Data.ConnectionState.Closed)
                conn.Close();

        }

    }

}
