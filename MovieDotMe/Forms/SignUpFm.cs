using MovieDotMe.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDotMe.Forms
{
    public partial class SignUpFm : Form
    {
        public SignUpFm()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DeleteTextBox()
        {
            UsernameBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
        }
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            var username = UsernameBox.Text;
            var password = PasswordBox.Text;

            // send Data

            var result = MyLogic.SignUp(username, password);

            if (!result)
            {
                var message = "username exist";
                MessageBox.Show(message);
                DeleteTextBox();
            }

        }
    }
}
