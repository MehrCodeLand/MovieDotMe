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
            button1 = new Button();
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
            BackBtn.Location = new Point(260, 394);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(112, 34);
            BackBtn.TabIndex = 0;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(582, 394);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 1;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MoviesName });
            dataGridView1.Location = new Point(482, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(212, 225);
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
            UsernameBox.Location = new Point(222, 119);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(254, 31);
            UsernameBox.TabIndex = 3;
            // 
            // UserProfileFm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 534);
            Controls.Add(UsernameBox);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(BackBtn);
            Name = "UserProfileFm";
            Text = "UserProfileFm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)faveMoviesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBtn;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource movieBindingSource;
        private BindingSource faveMoviesBindingSource;
        private DataGridViewTextBoxColumn MoviesName;
        private TextBox UsernameBox;
    }
}