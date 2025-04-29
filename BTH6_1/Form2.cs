using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH6_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int idselected;
        private void loadData()
        {
            DatabaseConnection dbConnect = new DatabaseConnection();
            SqlConnection conn = null;
            table_data.Items.Clear();
            try
            {
                conn = dbConnect.getConnection();
                SqlCommand cmd = new SqlCommand("select id,name, address, dateOfJoin, education, department from Employee", conn);
                //string sql = "select * from Login where username= '"+username_btn.Text.Trim()+"' and password = '"+pass_btn.Text.Trim()+"'";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {
                    ListViewItem item = new ListViewItem(data.GetInt32(0).ToString());
                    item.SubItems.Add(data.GetString(1));
                    item.SubItems.Add(data.GetString(2));
                    item.SubItems.Add(data.GetDateTime(3).ToShortDateString());
                    item.SubItems.Add(data.GetString(4));
                    item.SubItems.Add(data.GetString(5));
                    table_data.Items.Add(item);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối " + ex.Message);
            }
            finally
            {
                dbConnect.closeConnection(conn);
            }

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            loadData();
            table_data.FullRowSelect = true;
        }

        private void table_data_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (table_data.SelectedItems.Count != 0)
                idselected = Int16.Parse(table_data.SelectedItems[0].SubItems[0].Text);
            else
                idselected = -1;
            //MessageBox.Show(idselected.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnect = new DatabaseConnection();
            SqlConnection conn = null;
            try
            {
                if(idselected != -1)
                {
                    conn = dbConnect.getConnection();
                    SqlCommand cmd = new SqlCommand("delete Employee where id=@a", conn);
                    cmd.Parameters.AddWithValue("@a", idselected);
                    if(cmd.ExecuteNonQuery()!=0)
                    {
                        MessageBox.Show("Xóa thành công");
                    }

                }
                else
                {
                    MessageBox.Show("Vui lòng chọn");
                }
          
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối " + ex.Message);
            }
            finally
            {
                loadData();
                dbConnect.closeConnection(conn);
            }
        }
    }
}
