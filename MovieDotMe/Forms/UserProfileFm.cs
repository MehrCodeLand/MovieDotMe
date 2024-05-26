using MovieDotMe.Logic;
using MovieDotMe.Models;
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
    public partial class UserProfileFm : Form
    {
        private FaveMovies faveUserMovie = new FaveMovies();
        private User user;
        public UserProfileFm(User user)
        {
            InitializeComponent();
            this.user = user;
            FillDataGrid();
        }
        private void FillDataGrid()
        {
            faveUserMovie = MyLogic.GetFaveMovie(user.Username);
            List<string> titltes = faveUserMovie.Titles;

            for (int i = 0; i < titltes.Count; i++)
            {
                dataGridView1.Rows.Add(titltes[i]);
            }

            UsernameBox.Text = user.Username;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
