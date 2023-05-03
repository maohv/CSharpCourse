using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowForms
{
    public partial class LearnLabelTextbox : Form
    {
        public LearnLabelTextbox()
        {
            InitializeComponent();
        }

        private void btnLoginClicked(object sender, MouseEventArgs e)
        {
            var username = txtUserName.Text;
            var password = txtPassword.Text;
            var correctUsername = "mao@gmail.com";
            var correctPassword = "12345a@";
            if (username.CompareTo(correctUsername) == 0 &&
                password.CompareTo(correctPassword) == 0)
            {
                MessageBox.Show("Đăng nhập thành công");
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
            }
        }

        private void btnCancelClick(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }
}
