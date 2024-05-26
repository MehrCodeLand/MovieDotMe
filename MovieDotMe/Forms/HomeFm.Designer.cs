namespace MovieDotMe.Forms
{
    partial class HomeFm
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
            ExitBtn = new Button();
            SignInBtn = new Button();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(349, 199);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(75, 23);
            ExitBtn.TabIndex = 1;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // SignInBtn
            // 
            SignInBtn.Location = new Point(444, 199);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(75, 23);
            SignInBtn.TabIndex = 2;
            SignInBtn.Text = "Sign in";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(276, 120);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(286, 23);
            UsernameBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(276, 159);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(286, 23);
            PasswordBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(213, 123);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(213, 167);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // HomeFm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(SignInBtn);
            Controls.Add(ExitBtn);
            Name = "HomeFm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeFm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ExitBtn;
        private Button SignInBtn;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Label label1;
        private Label label2;
    }
}