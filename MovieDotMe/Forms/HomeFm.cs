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
    public partial class HomeFm : Form
    {
        public HomeFm()
        {
            InitializeComponent();
        }

        private void FillOutBoxes()
        {
            UsernameBox.Text = string.Empty;
            PasswordBox.Text = string.Empty;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MyLogic.CreateData();
            var mydata = MyLogic.GetAllUser();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            var resultSignIn = MyLogic.Login(UsernameBox.Text.Replace(" ", "")
                , PasswordBox.Text.Replace(" ", ""));

            if (resultSignIn == true)
            { 

                var user = MyLogic.GetUser(UsernameBox.Text.Replace(" ", ""));
                // sign in
                var movieHome = new MovieHomeFm(user);
                movieHome.ShowDialog();
            }
            else
            {
                var message = "somthing wrong";
                MessageBox.Show(message);
                FillOutBoxes();
            }
        }
    }
}
