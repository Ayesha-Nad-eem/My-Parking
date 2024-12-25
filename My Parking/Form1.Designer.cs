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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_UserName = new Label();
            lbl_Password = new Label();
            btn_login = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            checkBox1 = new CheckBox();
            login_panel = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lable_signup = new LinkLabel();
            login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_UserName
            // 
            lbl_UserName.Anchor = AnchorStyles.None;
            lbl_UserName.AutoSize = true;
            lbl_UserName.BackColor = Color.Transparent;
            lbl_UserName.FlatStyle = FlatStyle.Flat;
            lbl_UserName.Font = new Font("Times New Roman", 16.125F);
            lbl_UserName.Location = new Point(284, 358);
            lbl_UserName.Margin = new Padding(6, 0, 6, 0);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(191, 49);
            lbl_UserName.TabIndex = 0;
            lbl_UserName.Text = "Username";
            // 
            // lbl_Password
            // 
            lbl_Password.Anchor = AnchorStyles.None;
            lbl_Password.AutoSize = true;
            lbl_Password.BackColor = Color.Transparent;
            lbl_Password.FlatStyle = FlatStyle.Flat;
            lbl_Password.Font = new Font("Times New Roman", 16F);
            lbl_Password.Location = new Point(284, 491);
            lbl_Password.Margin = new Padding(6, 0, 6, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(185, 49);
            lbl_Password.TabIndex = 1;
            lbl_Password.Text = "Password";
            lbl_Password.Click += label2_Click;
            // 
            // btn_login
            // 
            btn_login.Anchor = AnchorStyles.None;
            btn_login.BackColor = Color.Maroon;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Times New Roman", 16F, FontStyle.Bold);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(284, 691);
            btn_login.Margin = new Padding(6, 6, 6, 6);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(475, 73);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.None;
            txt_username.Location = new Point(284, 414);
            txt_username.Margin = new Padding(6, 6, 6, 6);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(476, 51);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.None;
            txt_password.Location = new Point(284, 544);
            txt_password.Margin = new Padding(6, 6, 6, 6);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(476, 51);
            txt_password.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Font = new Font("Times New Roman", 12F);
            checkBox1.Location = new Point(284, 597);
            checkBox1.Margin = new Padding(6, 6, 6, 6);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(245, 40);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show password";
            checkBox1.UseVisualStyleBackColor = false;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // login_panel
            // 
            login_panel.Anchor = AnchorStyles.None;
            login_panel.BackColor = Color.Transparent;
            login_panel.Controls.Add(label2);
            login_panel.Controls.Add(pictureBox1);
            login_panel.Controls.Add(label1);
            login_panel.Controls.Add(lbl_Password);
            login_panel.Controls.Add(lable_signup);
            login_panel.Controls.Add(txt_username);
            login_panel.Controls.Add(txt_password);
            login_panel.Controls.Add(checkBox1);
            login_panel.Controls.Add(lbl_UserName);
            login_panel.Controls.Add(btn_login);
            login_panel.Location = new Point(359, 37);
            login_panel.Margin = new Padding(4, 2, 4, 2);
            login_panel.Name = "login_panel";
            login_panel.Size = new Size(999, 1101);
            login_panel.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            label2.Location = new Point(407, 235);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(233, 62);
            label2.TabIndex = 10;
            label2.Text = "Welcome";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F);
            label1.Location = new Point(284, 785);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(291, 36);
            label1.TabIndex = 8;
            label1.Text = "Don't have an acount?";
            // 
            // lable_signup
            // 
            lable_signup.Anchor = AnchorStyles.None;
            lable_signup.AutoSize = true;
            lable_signup.BackColor = Color.Transparent;
            lable_signup.Font = new Font("Times New Roman", 12F);
            lable_signup.Location = new Point(568, 785);
            lable_signup.Margin = new Padding(4, 0, 4, 0);
            lable_signup.Name = "lable_signup";
            lable_signup.Size = new Size(111, 36);
            lable_signup.TabIndex = 7;
            lable_signup.TabStop = true;
            lable_signup.Text = "Sign up";
            lable_signup.LinkClicked += lable_signup_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.WhatsApp_Image_2024_12_13_at_09_44_12_847faa21;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1515, 943);
            Controls.Add(login_panel);
            ForeColor = Color.Maroon;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            login_panel.ResumeLayout(false);
            login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_UserName;
        private Label lbl_Password;
        private Button btn_login;
        private TextBox txt_username;
        private TextBox txt_password;
        private CheckBox checkBox1;
        private Panel login_panel;
        private LinkLabel lable_signup;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
    }
}