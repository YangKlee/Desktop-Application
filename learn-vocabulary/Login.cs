using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace learn_vocabulary
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void showHidePass_btn_Click(object sender, EventArgs e)
        {
            if (password_tb.PasswordChar == '\0')
                password_tb.PasswordChar = '*';
            else
                password_tb.PasswordChar = '\0';
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // xu ly dang nhap
            UserDAO UD = new UserDAO();
            try
            {
                if (UD.verifyUser(username_tb.Text, password_tb.Text))
                {
                    MessageBox.Show("Login thành công!");
                }
                else
                {
                    MessageBox.Show("Login thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }


        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            Signin signinForm = new Signin();
            signinForm.ShowDialog();
        }
    }
}
