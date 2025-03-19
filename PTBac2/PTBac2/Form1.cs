using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTBac2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private float delta(int a, int b, int c)
        {
            return (float)(b * b) - (4.0f * (float)a * (float)c);
        }
        private void solve_bt_Click(object sender, EventArgs e)
        {

            
            try
            {
               
                int a = Int16.Parse(a_tb.Text);
                int b = Int16.Parse(b_tb.Text);
                int c = Int16.Parse(c_tb.Text);
                if (delta(a, b, c) < 0)
                {
                    result_tb.Text = "Vô nghiệm";
                }
                else if (delta(a, b, c) == 0)
                {
                    result_tb.Text = ((float)-b / 2.0f * a).ToString();
                }
                else
                {
                    float x1 = ((float)-b + delta(a, b, c)) / (2.0f * (float)a);
                    float x2 = ((float)-b - delta(a, b, c)) / (2.0f * (float)a);
                    result_tb.Multiline = true;
                    Console.WriteLine(x1);
                    result_tb.Text = $"x1 = {x1.ToString()} "+ Environment.NewLine + $"x2 = {x2.ToString()}";
                }
            }
            catch (Exception ex)
            {
                if (a_tb.Text == "" || b_tb.Text == "" || c_tb.Text == "")
                    MessageBox.Show("Chưa nhập đủ dữ liệu \n" + ex.Message, "Lỗi!" );
            }
        }

        private void earse_bt_Click(object sender, EventArgs e)
        {
            a_tb.Text = null;
            b_tb.Text = null;
            c_tb.Text = null;
            result_tb.Text = null;
        }

        private void exit_bt_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
