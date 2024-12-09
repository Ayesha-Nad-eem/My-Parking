namespace My_Parking
{
    partial class SignupForm
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
            checkbox = new CheckBox();
            txt_password = new TextBox();
            txt_username = new TextBox();
            btn_signup = new Button();
            lbl_Password = new Label();
            lbl_UserName = new Label();
            txt_ph = new TextBox();
            txt_email = new TextBox();
            lbl_ph = new Label();
            lbl_email = new Label();
            SuspendLayout();
            // 
            // checkbox
            // 
            checkbox.AutoSize = true;
            checkbox.Location = new Point(480, 122);
            checkbox.Name = "checkbox";
            checkbox.Size = new Size(108, 19);
            checkbox.TabIndex = 12;
            checkbox.Text = "Show password";
            checkbox.UseVisualStyleBackColor = true;
            checkbox.CheckedChanged += checkbox_CheckedChanged;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(278, 120);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(176, 23);
            txt_password.TabIndex = 11;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(278, 68);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(176, 23);
            txt_username.TabIndex = 10;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // btn_signup
            // 
            btn_signup.Location = new Point(310, 308);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(84, 34);
            btn_signup.TabIndex = 9;
            btn_signup.Text = "Sign up";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(193, 123);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(57, 15);
            lbl_Password.TabIndex = 8;
            lbl_Password.Text = "Password";
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Location = new Point(193, 71);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(60, 15);
            lbl_UserName.TabIndex = 7;
            lbl_UserName.Text = "Username";
            // 
            // txt_ph
            // 
            txt_ph.Location = new Point(278, 235);
            txt_ph.Name = "txt_ph";
            txt_ph.Size = new Size(176, 23);
            txt_ph.TabIndex = 16;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(278, 183);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(176, 23);
            txt_email.TabIndex = 15;
            // 
            // lbl_ph
            // 
            lbl_ph.AutoSize = true;
            lbl_ph.Location = new Point(193, 238);
            lbl_ph.Name = "lbl_ph";
            lbl_ph.Size = new Size(61, 15);
            lbl_ph.TabIndex = 14;
            lbl_ph.Text = "Phone no.";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(193, 186);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(36, 15);
            lbl_email.TabIndex = 13;
            lbl_email.Text = "Email";
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_ph);
            Controls.Add(txt_email);
            Controls.Add(lbl_ph);
            Controls.Add(lbl_email);
            Controls.Add(checkbox);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(btn_signup);
            Controls.Add(lbl_Password);
            Controls.Add(lbl_UserName);
            Name = "SignupForm";
            Text = "SignupForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkbox;
        private TextBox txt_password;
        private TextBox txt_username;
        private Button btn_signup;
        private Label lbl_Password;
        private Label lbl_UserName;
        private TextBox txt_ph;
        private TextBox txt_email;
        private Label lbl_ph;
        private Label lbl_email;
    }
}