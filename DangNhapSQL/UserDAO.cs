using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DangNhapSQL
{
    internal class UserDAO : DAO<User>
    {
        static string conString = "Data Source=YANGLAPTOP\\YANGSQLSERVER;Initial Catalog=qlhv;Integrated Security=True";
        SqlConnection conn = new SqlConnection(conString);
        public void Add(User obj)
        {
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into nguoidung values(@username, @pass)", conn);
                cmd.Parameters.AddWithValue("@username", obj.username);
                cmd.Parameters.AddWithValue("@pass", obj.password);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public User Get(string query)
        {
            return null;
        }
        public bool Verify(string username, string password)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from nguoidung where tendangnhap = @username and matkhau = @pass", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pass", password);
                SqlDataReader result = cmd.ExecuteReader();
                while (result.Read())
                {
                    if (username.Trim() == result["tendangnhap"].ToString().Trim() &&
                        password.Trim() == result["matkhau"].ToString().Trim())
                    {
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch(Exception ex)
            {
                
                throw;
            }
            finally
            {
                conn.Close();
            }
            return false;

        }
    }
}
