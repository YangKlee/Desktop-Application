using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testttt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void resetInput()
        {
            msv_tb.Text = null;
            hoten_tb.Text = null;
            diachi_tb.Text = null;
            ngaysinh_tb.Text = null;
            lop_tb.Text = null;
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            dsSV.Items.Add(msv_tb.Text);
            dsSV.Items[dsSV.Items.Count - 1].SubItems.Add(hoten_tb.Text);
            dsSV.Items[dsSV.Items.Count - 1].SubItems.Add(diachi_tb.Text);
            dsSV.Items[dsSV.Items.Count - 1].SubItems.Add(ngaysinh_tb.Text);
            dsSV.Items[dsSV.Items.Count - 1].SubItems.Add(lop_tb.Text);
            resetInput();
        }

        private void dsSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(dsSV.SelectedItems.Count > 0)
            {
                add_btn.Enabled = false;
                msv_tb.Enabled = false;
                int index = dsSV.Items.IndexOf(dsSV.SelectedItems[0]);
                //MessageBox.Show(dsSV.Items[index].Text);
                msv_tb.Text = dsSV.Items[index].Text;
                hoten_tb.Text = dsSV.Items[index].SubItems[1].Text;
                diachi_tb.Text = dsSV.Items[index].SubItems[2].Text;
                ngaysinh_tb.Text = dsSV.Items[index].SubItems[3].Text;
                lop_tb.Text = dsSV.Items[index].SubItems[4].Text;


            }
            else
            {
                add_btn.Enabled = true;
                msv_tb.Enabled = true;
            }
            
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            int index = dsSV.Items.IndexOf(dsSV.SelectedItems[0]);
            if (index != -1)
            {
                dsSV.Items[index].SubItems[1].Text = (hoten_tb.Text);
                dsSV.Items[index].SubItems[2].Text = (diachi_tb.Text);
                dsSV.Items[index].SubItems[3].Text = (ngaysinh_tb.Text);
                dsSV.Items[index].SubItems[4].Text = (lop_tb.Text);
            }
            add_btn.Enabled = true;
            msv_tb.Enabled = true;
            resetInput();
        }
    }
}
