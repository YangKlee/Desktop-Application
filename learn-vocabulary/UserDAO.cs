using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learn_vocabulary
{
    internal class UserDAO : UserIDAO
    {
        string connString = "Data Source=YANGLAPTOP\\YANGSQLSERVER;Initial Catalog=Vocabulary;Integrated Security=True";
        
        public void addUser(User newUser)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Users values(@username, @email, @password)", conn);
                cmd.Parameters.AddWithValue("@username", newUser.userName);
                cmd.Parameters.AddWithValue("@email", newUser.email);
                cmd.Parameters.AddWithValue("@password", newUser.password);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                throw;
            }

           
        }

        public bool verifyUser(string userName, string password)
        {
            try
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand cmd = new SqlCommand("select count(*) from Users where username = @user and password = @pass", conn);
                cmd.Parameters.AddWithValue("@user", userName);
                cmd.Parameters.AddWithValue("@pass", password);
                object result = cmd.ExecuteScalar();
                int count = 0;
                count = Convert.ToInt32(result ?? 0);
                if (count != 0)
                    return true;
                else
                    return false;
                conn.Close();
            }
            catch
            {
                throw;
                
            }
        }
    }
}
