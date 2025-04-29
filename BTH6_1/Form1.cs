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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnect = new DatabaseConnection();
            SqlConnection conn = null;
            try
            {
                conn = dbConnect.getConnection();
                SqlCommand cmd = new SqlCommand("select * from Login where username=@user and password =@pass", conn);
                cmd.Parameters.AddWithValue("@user", username_btn.Text);
                cmd.Parameters.AddWithValue("@pass", pass_btn.Text);
                //string sql = "select * from Login where username= '"+username_btn.Text.Trim()+"' and password = '"+pass_btn.Text.Trim()+"'";
                //SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if(data.Read())
                {
                    MessageBox.Show("Login thành công");
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login thật bại");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối " + ex.Message);
            }
            finally
            {
                dbConnect.closeConnection(conn);
            }

        }
    }
}
