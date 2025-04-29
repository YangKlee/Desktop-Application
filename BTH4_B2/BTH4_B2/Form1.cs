using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_B2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void reset()
        {
            hoten_tb.Text = null;
            msv_tb.Text = null;
            nienkhoa_cbox.Text = null;
            lop_cbox.Text = null;
            hk1_chkb.Checked = false;
            hk2_cb.Checked = false;
            hk3_chkb.Checked = false;
            hk4_chkb.Checked = false;
            for (int i = 1; i < subject_chklist.Items.Count; i++)
            {
                subject_chklist.SetItemChecked(i, false);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = hoten_tb.Text.Trim();
            string msv = msv_tb.Text.Trim();
            string nienKhoa = nienkhoa_cbox.Text;
            string lop = lop_cbox.Text;
            int hocky = -1;
            if (hk1_chkb.Checked)
                hocky = 1;
            else if (hk2_cb.Checked)
                hocky = 2;
            else if (hk3_chkb.Checked)
                hocky = 3;
            else if (hk4_chkb.Checked)
                hocky = 4;
            string output = $"Sinh viên: {name}\nLớp: {lop}\nNiên khóa: {nienKhoa}\nĐã đăng ký học học kỳ {hocky} các môn học sau:\n";
            int count = 0;
            foreach (string x in subject_chklist.CheckedItems)
            {
                count++;
                output += $"{count}.{x} \n"; 
            }
            MessageBox.Show(output.Trim());
            reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
