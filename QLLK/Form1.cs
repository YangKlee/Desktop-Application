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
    public partial class QLLK : Form
    {
        public static string ConnectionString = "Data Source=YANGLAPTOP\\YANGSQLSERVER;Initial Catalog=QLLK;Integrated Security=True";
        public QLLK()
        {
            InitializeComponent();
        }
        private void loadListCustomer()
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string sql = "Select idKhachHang, tenKhachHang from KHACHHANG";
                SqlDataAdapter data = new SqlDataAdapter(sql, conn);
                DataTable dataTable = new DataTable();
                data.Fill(dataTable);
                customer_combobox.DataSource = dataTable;
                customer_combobox.DisplayMember = "tenKhachHang";
                customer_combobox.ValueMember = "idKhachHang";
                data.Dispose();
                customer_combobox.SelectedIndex = -1;

            }
        }
        private void loadLinkKien(int idCustomer)
        {
            using(SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select idLinhKien, TenLinhKien, LoaiLinhKien, GiaBan from LINHKIEN " +
                    "WHERE idKhachHang = @idcus", conn);
                cmd.Parameters.AddWithValue("@idcus", idCustomer);
                SqlDataAdapter adaper = new SqlDataAdapter(cmd);
                DataTable dtb = new DataTable();
                adaper.Fill(dtb);
                dataGridView1.DataSource = dtb;
            }
        }
        private void QLLK_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loadListCustomer();
        }

        private void customer_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void customer_combobox_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        public static int idKhachHang = -1;
        private void customer_combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idKhachHang = (int)customer_combobox.SelectedValue;
            loadLinkKien(idKhachHang);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if(idKhachHang == -1 || customer_combobox.SelectedIndex == -1)
            {
                MessageBox.Show("Chưa chọn khách hàng");
            }
            else
            {
                add fadd = new add();
                fadd.ShowDialog();
                loadLinkKien(idKhachHang);
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Muốn xóa k?", "Xác nhận", MessageBoxButtons.YesNo);
            if(choice == DialogResult.Yes)
            {
                if (idKhachHang == -1 || customer_combobox.SelectedIndex == -1)
                {
                    MessageBox.Show("Chưa chọn khách hàng");
                }
                else if(dataGridView1.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Chưa chọn linh kiện");
                }
                else
                {
                    string idlinhkien = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    using(SqlConnection conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        using(SqlCommand cmd = new SqlCommand("Delete LINHKIEN where idlinhkien = @id", conn))
                        {
                            cmd.Parameters.AddWithValue("@id", idlinhkien);
                            if(cmd.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Xóa thành công");
                            }    
                            else
                            {
                                MessageBox.Show("Xóa k thành công");
                            }
                        }

                        
                    }
                    loadLinkKien(idKhachHang);
                }
            }
            

        }
    }
}
