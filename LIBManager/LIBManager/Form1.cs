using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIBManager
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void updateDataTable()
        {
            BookDAO bookdao = new BookDAO();
            try
            {
                dataGrid.DataSource = bookdao.getAll();
                dataGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ", ex.Message);
            }
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            toolStrip1.ImageList = buttonImageList;
            updateDataTable();
        }

        private void push_Click(object sender, EventArgs e)
        {
            BookDAO bookdao =new BookDAO();
            Book item = new Book();
            item.Title = textBoxTitle.Text;
            item.Author = textBoxAuthor.Text;
            item.Topic = textBoxTopic.Text;
            item.PageCount = Int16.Parse(textBoxPage.Text);
            item.Code = textBoxCode.Text;
            bookdao.add(item);
            updateDataTable();
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void reload_Click(object sender, EventArgs e)
        {
            updateDataTable();
        }

        private void modify_Click(object sender, EventArgs e)
        {


        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {

            int idSelect = -1;
            if (dataGrid.SelectedRows.Count > 0)
            {
                idSelect = Int16.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString());
                BookDAO bookDao = new BookDAO();
                Book selected = bookDao.get(idSelect);
                textBoxTitle.Text = selected.Title;
                textBoxAuthor.Text = selected.Author;
                textBoxTopic.Text = selected.Topic;
                textBoxPage.Text = selected.PageCount.ToString();
                textBoxCode.Text = selected.Code;
            }
        }

        private void minus_Click(object sender, EventArgs e)
        {
            int idSelect = -1;
            if (dataGrid.SelectedRows.Count > 0)
            {
                idSelect = Int16.Parse(dataGrid.SelectedRows[0].Cells[0].Value.ToString());
                BookDAO bookDao = new BookDAO();
                bookDao.delete(idSelect);
                updateDataTable();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
