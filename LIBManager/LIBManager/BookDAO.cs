using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIBManager
{
    internal class BookDAO : DAO<Book>
    {
        public bool add(Book item)
        {
            bool isSuccess = false;
            DatabaseConnection dbconn = new DatabaseConnection();
            SqlConnection conn = dbconn.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Insert into Books(Title, Author, PageCount, Topic, Code) " +
                "values(@title, @author, @pagecount, @topic, @code)", conn);
                cmd.Parameters.AddWithValue("title", item.Title);
                cmd.Parameters.AddWithValue("author", item.Author);
                cmd.Parameters.AddWithValue("pagecount", item.PageCount);
                cmd.Parameters.AddWithValue("topic", item.Topic);
                cmd.Parameters.AddWithValue("code", item.Code);


                if (cmd.ExecuteNonQuery() != 0)
                    isSuccess = true;

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn" + ex.Message);
            }
            finally
            {
                dbconn.closeConnection(conn);
            }
            return isSuccess;

        }

        public bool delete(int id)
        {
            bool isSuccess = false;
            DatabaseConnection dbconn = new DatabaseConnection();
            SqlConnection conn = dbconn.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Delete Books where bookID = @id", conn);
                cmd.Parameters.AddWithValue("id", id);


                if (cmd.ExecuteNonQuery() != 0)
                    isSuccess = true;

            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn" + ex.Message);
            }
            finally
            {
                dbconn.closeConnection(conn);
            }
            return isSuccess;
        }

        public bool delete(Book item)
        {
            throw new NotImplementedException();
        }

        public Book get(string query)
        {
            throw new NotImplementedException();
        }

        public Book get(int id)
        {
            DatabaseConnection dbconn = new DatabaseConnection();
            SqlConnection conn = dbconn.getConnection();
            Book data = new Book();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Books where BookID = @id", conn);
                cmd.Parameters.AddWithValue("id", id);
                SqlDataReader dataRaw = cmd.ExecuteReader();
                dataRaw.Read();
                data.BookID = dataRaw.GetInt32(0);
                data.Title = dataRaw.GetString(1);
                data.Author = dataRaw.GetString(2);
                data.PageCount = dataRaw.GetInt32(3);
                data.Topic = dataRaw.GetString(4);
                data.Code = dataRaw.GetString(5);


            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn" + ex.Message);
            }
            finally
            {
                dbconn.closeConnection(conn);
            }
            return data;
        }

        public DataTable getAll()
        {

            DatabaseConnection dbconn = new DatabaseConnection();
            SqlConnection conn = dbconn.getConnection();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from Books", conn);
                SqlDataAdapter sqlAP = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sqlAP.Fill(ds);
                return ds.Tables[0];
        
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi truy vấn" + ex.Message);
            }
            finally
            {
                dbconn.closeConnection(conn);
            }
        }

        public DataTable getElemetsWithQuery(string query)
        {
            throw new NotImplementedException();
        }

        public bool modify(int id, Book change)
        {
            throw new NotImplementedException();
        }

        public bool modify(Book oldItem, Book newItem)
        {
            throw new NotImplementedException();
        }
    }
}
