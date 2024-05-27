namespace MovieDotMe.Forms
{
    partial class MovieHomeFm
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
            dataGridView1 = new DataGridView();
            movieIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            directorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movieBindingSource = new BindingSource(components);
            BackBtn = new Button();
            MyProfileBtn = new Button();
            SearchBox = new TextBox();
            SearchBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { movieIDDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, directorDataGridViewTextBoxColumn });
            dataGridView1.DataSource = movieBindingSource;
            dataGridView1.Location = new Point(218, 100);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(343, 193);
            dataGridView1.TabIndex = 0;
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            movieIDDataGridViewTextBoxColumn.DataPropertyName = "MovieID";
            movieIDDataGridViewTextBoxColumn.HeaderText = "MovieID";
            movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Title";
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // directorDataGridViewTextBoxColumn
            // 
            directorDataGridViewTextBoxColumn.DataPropertyName = "Director";
            directorDataGridViewTextBoxColumn.HeaderText = "Director";
            directorDataGridViewTextBoxColumn.Name = "directorDataGridViewTextBoxColumn";
            // 
            // movieBindingSource
            // 
            movieBindingSource.DataSource = typeof(Models.Movie);
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(229, 340);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(75, 23);
            BackBtn.TabIndex = 1;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // MyProfileBtn
            // 
            MyProfileBtn.Location = new Point(468, 340);
            MyProfileBtn.Name = "MyProfileBtn";
            MyProfileBtn.Size = new Size(75, 23);
            MyProfileBtn.TabIndex = 2;
            MyProfileBtn.Text = "My Profile";
            MyProfileBtn.UseVisualStyleBackColor = true;
            MyProfileBtn.Click += MyProfileBtn_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(277, 71);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(284, 23);
            SearchBox.TabIndex = 3;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(218, 71);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(53, 23);
            SearchBtn.TabIndex = 5;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // MovieHomeFm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBox);
            Controls.Add(MyProfileBtn);
            Controls.Add(BackBtn);
            Controls.Add(dataGridView1);
            Name = "MovieHomeFm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MovieHomeFm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BackBtn;
        private DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn directorDataGridViewTextBoxColumn;
        private BindingSource movieBindingSource;
        private Button MyProfileBtn;
        private TextBox SearchBox;
        private Button SearchBtn;
    }
}