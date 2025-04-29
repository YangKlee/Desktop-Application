using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DangNhapSQL
{
    internal class DatabaseConnection
    {

        static string conString = "Data Source=YANGLAPTOP\\YANGSQLSERVER;Initial Catalog=qlhv;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection conn = new SqlConnection(conString);
       
 


    }
}
