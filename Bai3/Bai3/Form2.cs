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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Education_select.SelectedIndex = 0 ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name_tb.Text = null;
            Address_tb.Text = null;
            Date_tb.Text = null;
            Education_select.SelectedIndex = 0;
            Depair_tb.Text = null;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
