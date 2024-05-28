﻿namespace MovieDotMe.Forms
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
            SignUpBtn = new Button();
            SuspendLayout();
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(499, 332);
            ExitBtn.Margin = new Padding(4, 5, 4, 5);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(107, 38);
            ExitBtn.TabIndex = 1;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // SignInBtn
            // 
            SignInBtn.Location = new Point(634, 332);
            SignInBtn.Margin = new Padding(4, 5, 4, 5);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(107, 38);
            SignInBtn.TabIndex = 2;
            SignInBtn.Text = "Sign in";
            SignInBtn.UseVisualStyleBackColor = true;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(394, 200);
            UsernameBox.Margin = new Padding(4, 5, 4, 5);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(407, 31);
            UsernameBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(394, 265);
            PasswordBox.Margin = new Padding(4, 5, 4, 5);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(407, 31);
            PasswordBox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 205);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 278);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 6;
            label2.Text = "Password";
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(873, 193);
            SignUpBtn.Margin = new Padding(4, 5, 4, 5);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(107, 38);
            SignUpBtn.TabIndex = 7;
            SignUpBtn.Text = "sign Up";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // HomeFm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.daniele_levis_pelusi_mkMSXR86kYY_unsplash;
            ClientSize = new Size(1143, 750);
            Controls.Add(SignUpBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(SignInBtn);
            Controls.Add(ExitBtn);
            Margin = new Padding(4, 5, 4, 5);
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
        private Button SignUpBtn;
    }
}