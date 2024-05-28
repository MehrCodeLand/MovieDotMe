namespace MovieDotMe.Forms
{
    partial class UserProfileFm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BackBtn = new Button();
            dataGridView1 = new DataGridView();
            MoviesName = new DataGridViewTextBoxColumn();
            movieBindingSource = new BindingSource(components);
            faveMoviesBindingSource = new BindingSource(components);
            UsernameBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)faveMoviesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(229, 262);
            BackBtn.Margin = new Padding(2);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(212, 20);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MoviesName });
            dataGridView1.Location = new Point(229, 80);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(212, 178);
            dataGridView1.TabIndex = 2;
            // 
            // MoviesName
            // 
            MoviesName.HeaderText = "Movie";
            MoviesName.MinimumWidth = 8;
            MoviesName.Name = "MoviesName";
            MoviesName.Width = 150;
            // 
            // movieBindingSource
            // 
            movieBindingSource.DataSource = typeof(Models.Movie);
            // 
            // faveMoviesBindingSource
            // 
            faveMoviesBindingSource.DataSource = typeof(Models.FaveMovies);
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(229, 53);
            UsernameBox.Margin = new Padding(2);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(212, 23);
            UsernameBox.TabIndex = 3;
            // 
            // UserProfileFm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 320);
            Controls.Add(UsernameBox);
            Controls.Add(dataGridView1);
            Controls.Add(BackBtn);
            Margin = new Padding(2);
            Name = "UserProfileFm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)faveMoviesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private DataGridView dataGridView1;
        private BindingSource movieBindingSource;
        private BindingSource faveMoviesBindingSource;
        private DataGridViewTextBoxColumn MoviesName;
        private TextBox UsernameBox;
    }
}