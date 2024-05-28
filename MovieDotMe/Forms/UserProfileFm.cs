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

            dataGridView1.CellDoubleClick += dataGrid_cell;
        }
        private void FillDataGrid()
        {
            faveUserMovie = MyLogic.GetFaveMovie(user.Username);
            if (faveUserMovie != null && faveUserMovie.Titles != null)
            {
                List<string> titltes = faveUserMovie.Titles;

                for (int i = 0; i < titltes.Count; i++)
                {
                    dataGridView1.Rows.Add(titltes[i]);
                }
            }
            UsernameBox.Text = user.Username;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGrid_cell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string movieTitle = (string)selectedRow.Cells[0].Value;

                // delete movie from list
                MyLogic.RemoveFromList(movieTitle, faveUserMovie);
                
            }

            FillDataGrid();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
