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
        public int oldFaveMovieCount = 0;
        private User user;
        public MovieHomeFm(User user)
        {
            InitializeComponent();
            CreateDataFilm();
            FillDataGrid();
            this.user = user;
            GetFaveUser();
            oldFaveMovieCount = faveUserMovie.Titles.Count;
            dataGridView1.CellDoubleClick += dataGrid_cell;
        }

        private void CreateFakeList()
        {
            if (faveUserMovie.Titles == null)
            {
                faveUserMovie.Titles = new List<string>();
            }
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
            var fave = MyLogic.GetFaveMovie(user.Username);
            if (fave != null)
            {
                faveUserMovie = fave;
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (faveUserMovie != null)
            {
                // before he goes we save all name and title
                MyLogic.SaveFavoritMovies(faveUserMovie.Titles, user);
                faveUserMovie = MyLogic.GetFaveMovie(user.Username);
            }
            this.Close();
        }
        private void dataGrid_cell(object sender, DataGridViewCellEventArgs e)
        {

            CreateFakeList();

            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string movieTitle = (string)selectedRow.Cells[1].Value;

                if (faveUserMovie.Titles.Any(x => x == movieTitle))
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
            if (faveUserMovie.Titles.Count != oldFaveMovieCount)
            {
                MyLogic.SaveFavoritMovies(faveUserMovie.Titles, user);

                // new list is created 
                faveUserMovie = MyLogic.GetFaveMovie(user.Username);
            }

            var profileFm = new UserProfileFm(user);
            profileFm.ShowDialog();
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // time to search

            var searchText = SearchBox.Text;

            if (searchText.Length == 0)
            {
                FillDataGrid();
            }
            else
            {
                var searched = MyLogic.SearchMovieTitle(searchText);

                dataGridView1.DataSource = searched.ToList();
            }
        }
    }
}
