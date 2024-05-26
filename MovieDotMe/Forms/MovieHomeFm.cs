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
    public partial class MovieHomeFm : Form
    {
        private FaveMovies faveUserMovie = new FaveMovies();

        private User user;
        public MovieHomeFm(User user)
        {
            InitializeComponent();
            CreateDataFilm();
            FillDataGrid();
            this.user = user;
            GetFaveUser();
            
            dataGridView1.CellDoubleClick += dataGrid_cell;

        }
        private void CreateDataFilm()
        {
            MyLogic.CreateMovies();
        }
        private void FillDataGrid()
        {
            dataGridView1.DataSource = MyLogic.GetAllMovies();
        }
        private void GetFaveUser()
        {
            faveUserMovie = MyLogic.GetFaveMovie(user.Username);
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {

            // before he goes we save all name and title
            MyLogic.SaveFavoritMovies(faveUserMovie.Titles, user);
            this.Close();
        }

        private void dataGrid_cell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string movieTitle = (string)selectedRow.Cells[1].Value;

                if(faveUserMovie.Titles.Any(x => x == movieTitle))
                {
                    var message = "it is already added";
                    MessageBox.Show(message);
                }
                else
                {
                    faveUserMovie.Titles.Add(movieTitle);
                }
            }
        }
        private void MyProfileBtn_Click(object sender, EventArgs e)
        {
            MyLogic.SaveFavoritMovies(faveUserMovie.Titles, user);

            var profileFm = new UserProfileFm(user);
            profileFm.ShowDialog();
        }
    }
}
