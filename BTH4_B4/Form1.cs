using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTH4_B4
{
    public partial class Form1 : Form
    {
        List<SinhVien> dsSV = new List<SinhVien>();
        int indexSelect = -1;
        public Form1()
        {
            InitializeComponent();
        }
        private void updateListView()
        {

            listView.Items.Clear();
            foreach (SinhVien sv in dsSV)
            {
                ListViewItem data = new ListViewItem(sv.maSinhVien);
                //data.SubItems.Add(sv.maSinhVien);
                Console.WriteLine(sv.hoTen);
                data.SubItems.Add(sv.hoTen);
                data.SubItems.Add(sv.DiaChi);
                data.SubItems.Add(sv.ngaySinh.ToShortDateString());
                data.SubItems.Add(sv.lop);
                listView.Items.Add(data);
            }
        }
        private void resetInput()
        {
            msv_tb.Text = null;
            hoten_tb.Text = null;
            diachi_tb.Text = null;
            ngaysinh_tb.Value = DateTime.Now;
            lop_tb.Text = null;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dsSV.Add(new SinhVien(msv_tb.Text, hoten_tb.Text, diachi_tb.Text, ngaysinh_tb.Value, lop_tb.Text));
            updateListView();
            resetInput();
        }
        void resetForm()
        {
            add_btn.Enabled = true;
            edit_btn.Enabled = false;
            delete_btn.Enabled = false;
        }
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView.SelectedIndices.Count!= 0)
            {
                add_btn.Enabled = false;
                edit_btn.Enabled = true;
                delete_btn.Enabled = true;
                indexSelect = listView.SelectedIndices[0];
                msv_tb.Text = dsSV[indexSelect].maSinhVien;
                hoten_tb.Text = dsSV[indexSelect].hoTen;
                diachi_tb.Text = dsSV[indexSelect].DiaChi;
                ngaysinh_tb.Value = dsSV[indexSelect].ngaySinh;
                lop_tb.Text = dsSV[indexSelect].lop;

            }
            else
            {
                resetInput();
                add_btn.Enabled = true;
                edit_btn.Enabled = false;
                delete_btn.Enabled = false;
            }
        }

        private void listView_Leave(object sender, EventArgs e)
        {
           

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            dsSV[indexSelect] = new SinhVien(msv_tb.Text, hoten_tb.Text, diachi_tb.Text, ngaysinh_tb.Value, lop_tb.Text);
            int index = listView.SelectedIndices[0];
            MessageBox.Show(index.ToString());
            updateListView();
            resetInput();
            resetForm();

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            dsSV.RemoveAt(indexSelect);
            updateListView();
            resetInput();
            resetForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            edit_btn.Enabled = false;
            delete_btn.Enabled = false;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
