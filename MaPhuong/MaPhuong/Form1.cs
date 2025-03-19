using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaPhuong
{

    public partial class Form1 : Form
    {
        int n = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void createMaPhuongLe(int[,] a)
        {
            int count = 1;
            int i = 1;
            int j = (n / 2) + 1;
            
            while (count <= n*n)
            {
                Console.WriteLine($"i = {i}, j = {j} ");
                if ((i < 1 && j >=1) && j <= n)
                {
                    i = n;
                    
                    continue;
                }
                else if ((i >= 1 && j > n) && (i <= n))
                {
                    
                    j = 1;
                    continue;
                }
                else if ((i < 1 && j > n))
                {
                    i++; j--;
                    i++;
                    continue;
                }
                else if (a[i, j] != 0)
                {
                    i++; j--;
                    i++;
                    continue;
                }
                else
                {
                    a[i, j] = count;
                    i--; j++;
                    count++;
                }

            }    
        }
        private void createMaPhuong4N(int[,] a)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {

                }
            }
        }
        private void showTable(int[,] a)
        {
            table_data.Columns.Clear();
            table_data.Rows.Clear();
            for (int i = 0; i < n; i++)
            {
                table_data.Columns.Add("" + i, "" + (i + 1));
            }
            table_data.Columns.Add("result", "result");
            for (int i = 0; i < n; i++)
            {
                table_data.Rows.Add();
                for (int j = 0; j < n; j++)
                {
                    table_data.Rows[i].Cells[j].Value = a[i + 1, j +1];
                }
            }
            table_data.Rows.Add();
            // check
            int sumcheo = 0;
            int result = (n * ((n * n) + 1)) / 2;
            for (int i = 0; i < n; i++)
            {
                int sumr = 0, sumc = 0;
                for (int j = 0; j < n; j++)
                {
                    sumr += a[i+1, j+1];
                    sumc += a[j + 1, i + 1];
                    if (i == j)
                        sumcheo += a[i + 1, j + 1];
                }
                //MessageBox.Show(result.ToString());
                if (sumr != result)
                {
                    table_data.Rows[i].Cells[n].Style.BackColor = Color.Red;

                }
                else
                {
                    table_data.Rows[i].Cells[n].Style.BackColor = Color.Green;
                }

                if (sumc != result)
                {
                    table_data.Rows[n].Cells[i].Style.BackColor = Color.Red;
                }
                else
                {
                    table_data.Rows[n].Cells[i].Style.BackColor = Color.Green;
                }
                if (sumcheo != result)
                {
                    table_data.Rows[n].Cells[n].Style.BackColor = Color.Red;
                }
                else
                {
                    table_data.Rows[n].Cells[n].Style.BackColor = Color.Green;
                }
                table_data.Rows[i].Cells[n].Value = "= " + sumr;
                table_data.Rows[n].Cells[i].Value = "= " + sumc;
                table_data.Rows[n].Cells[n].Value = "= " + sumcheo;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
           // try
            {
                n = Int16.Parse(n_tb.Text);
                int[,] a = new int[n+1, n+1];
                if (n >= 3)
                {
                    if (n % 2 != 0)
                    {
                        // ma phuong le
                        createMaPhuongLe(a);
                        showTable(a);
                    }
                    else if (n%2 == 0 && n % 4 == 0)
                    {

                        // ma phuong 4n
                    }
                    else if (n%2 == 0 && n % 4 != 0)
                    {
                        // ma phuong 4n +2
                    }
                }
                else
                {
                    MessageBox.Show("N phải lớn hơn 3");
                    n_tb.Text = null;
                }
            }
            //catch (Exception ex)
            {
               // MessageBox.Show(ex.Message);
               //n_tb.Text = null;
            }


        }
    }
}
