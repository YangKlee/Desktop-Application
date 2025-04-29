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
    public partial class Signin : Form
    {
        public Signin()
        {
            InitializeComponent();
        }

        private void backLogin_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void resetInput()
        {
            userName_tb.Text = null;
            Email_tb.Text = null;
            Password_tb.Text = null;
            rePassword_tb.Text = null;
        }
        private void sigin_btn_Click(object sender, EventArgs e)
        {
            if (rePassword_tb.Text == Password_tb.Text)
            {
                try
                {
                    UserDAO UD = new UserDAO();
                    User newUser = new User(userName_tb.Text, Email_tb.Text, Password_tb.Text);
                    UD.addUser(newUser);
                    MessageBox.Show("Đăng ký thành công gòi");
                    resetInput();
                }
                catch
                {
                    MessageBox.Show("Đăng ký thất bại nè");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu không khớp kìa~");
            }
        }
    }
}
