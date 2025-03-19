using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Color> colorList = new List<Color> { Color.Red, Color.Green, Color.Blue, Color.Gray, Color.Orange, Color.Yellow, Color.Blue };
        int i = 0;
        const string USERNAME = "Admin";
        const string PASSWORD = "Admin";
        private void button2_Click(object sender, EventArgs e)
        {
            if(userName_tb.Text == USERNAME && password_tb.Text == PASSWORD)
            {
                MessageBox.Show("Login Complete~", "Noficaton");
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Nofication"); 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (i > 6)
            {
                i = 0;
            }
                this.BackColor = colorList[i];
            i++;
        }
    }
}
