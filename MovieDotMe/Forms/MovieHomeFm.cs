﻿using MovieDotMe.Logic;
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
        private List<string> moviesTitle = new List<string>();
        private User user;
        public MovieHomeFm(User user)
        {
            InitializeComponent();
            CreateDataFilm();
            FillDataGrid();
            this.user = user;

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
        private void BackBtn_Click(object sender, EventArgs e)
        {

            // before he goes we save all name and title
            this.Close();
        }

        private void dataGrid_cell(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                dataGridView1.Rows[e.RowIndex].Selected = true;
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                string movieTitle = (string)selectedRow.Cells[1].Value;

                if( moviesTitle.Any(x => x == movieTitle))
                {
                    var message = "it is already added";
                    MessageBox.Show(message);
                }
                else
                {
                    moviesTitle.Add(movieTitle);
                }
            }
        }
        private void MyProfileBtn_Click(object sender, EventArgs e)
        {
            MyLogic.SaveFavoritMovies(moviesTitle, user);
        }
    }
}