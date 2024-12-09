namespace My_Parking
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_UserName = new Label();
            lbl_Password = new Label();
            btn_login = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_SignUp = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Location = new Point(122, 45);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(60, 15);
            lbl_UserName.TabIndex = 0;
            lbl_UserName.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(122, 97);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(57, 15);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password";
            lbl_Password.Click += label2_Click;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(251, 150);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(84, 34);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(207, 42);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(176, 23);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(207, 94);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(176, 23);
            txt_password.TabIndex = 4;
            // 
            // btn_SignUp
            // 
            btn_SignUp.Location = new Point(321, 216);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new Size(75, 23);
            btn_SignUp.TabIndex = 5;
            btn_SignUp.Text = "Sign up";
            btn_SignUp.UseVisualStyleBackColor = true;
            btn_SignUp.Click += btn_SignUp_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(409, 96);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 377);
            Controls.Add(checkBox1);
            Controls.Add(btn_SignUp);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(btn_login);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_UserName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_UserName;
        private Label lbl_Password;
        private Button btn_login;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_SignUp;
        private CheckBox checkBox1;
    }
}