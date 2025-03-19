using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string userName = "";
        string passWord = "";
        private void login_bt_Click(object sender, EventArgs e)
        {
            if (username_tx.Text == userName && pass_tx.Text == passWord)
            {
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                try
                {
                    this.Show();
                }
                catch { };
                             
            }
        }
    }
}
