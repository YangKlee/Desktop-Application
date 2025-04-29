using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                lsBox.Items.Add(Int16.Parse(num_tb.Text));
            }
            catch
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ~!", "Lỗi", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            num_tb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < lsBox.Items.Count; i++)
            {

                sum += Convert.ToUInt16(lsBox.Items[i]);

            }
            MessageBox.Show(sum.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsBox.Items.Count; i++)
            {

                lsBox.Items[i] = Int16.Parse(lsBox.Items[i].ToString()) + 2;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                lsBox.Items.Remove(lsBox.Items[0]);
                lsBox.Items.Remove(lsBox.Items[lsBox.Items.Count - 1]);
            }
            catch
            {

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (lsBox.SelectedIndex != -1)
            {
                lsBox.Items.RemoveAt(lsBox.SelectedIndex);

            }
            else
                MessageBox.Show("Chưa chọn phần tử");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lsBox.Items.Count; i++)
            {

                lsBox.Items[i] = Math.Pow(Convert.ToInt16(lsBox.Items[i]),2);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
