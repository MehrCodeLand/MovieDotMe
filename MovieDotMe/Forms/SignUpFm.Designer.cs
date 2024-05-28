namespace MovieDotMe.Forms
{
    partial class SignUpFm
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
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SignUpBtn = new Button();
            BackBtn = new Button();
            SuspendLayout();
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(256, 91);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(289, 31);
            UsernameBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(256, 147);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(289, 31);
            PasswordBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(149, 94);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 153);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // SignUpBtn
            // 
            SignUpBtn.Location = new Point(433, 216);
            SignUpBtn.Name = "SignUpBtn";
            SignUpBtn.Size = new Size(112, 34);
            SignUpBtn.TabIndex = 4;
            SignUpBtn.Text = "SignUp";
            SignUpBtn.UseVisualStyleBackColor = true;
            SignUpBtn.Click += SignUpBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(256, 216);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(112, 34);
            BackBtn.TabIndex = 5;
            BackBtn.Text = "Back";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // SignUpFm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BackBtn);
            Controls.Add(SignUpBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Name = "SignUpFm";
            Text = "SignUpFm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Label label1;
        private Label label2;
        private Button SignUpBtn;
        private Button BackBtn;
    }
}