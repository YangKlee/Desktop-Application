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

namespace QLLK
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(QLLK.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO LINHKIEN (TenLinhKien, LoaiLinhKien, GiaBan, idKhachHang) " +
                    "VALUES(@name, @type, @price, @idcus)", conn))
                    {
                        cmd.Parameters.AddWithValue("@name", name_tb.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", type_tb.Text.Trim());
                        cmd.Parameters.AddWithValue("@price", price_tb.Text.Trim());
                        cmd.Parameters.AddWithValue("@idcus", QLLK.idKhachHang);
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("thêm thành công");
                        }
                        else
                        {
                            MessageBox.Show("thêm thất bại");
                        }

                    }

                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
