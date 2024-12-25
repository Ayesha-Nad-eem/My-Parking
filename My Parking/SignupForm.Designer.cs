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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignupForm));
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
            signup_panel = new Panel();
            signup_logo = new PictureBox();
            signup_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)signup_logo).BeginInit();
            SuspendLayout();
            // 
            // checkbox
            // 
            checkbox.Anchor = AnchorStyles.None;
            checkbox.AutoSize = true;
            checkbox.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkbox.ForeColor = Color.Maroon;
            checkbox.Location = new Point(276, 718);
            checkbox.Margin = new Padding(6, 5, 6, 5);
            checkbox.Name = "checkbox";
            checkbox.Size = new Size(193, 31);
            checkbox.TabIndex = 12;
            checkbox.Text = "Show password";
            checkbox.UseVisualStyleBackColor = true;
            checkbox.CheckedChanged += checkbox_CheckedChanged;
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.None;
            txt_password.Location = new Point(276, 657);
            txt_password.Margin = new Padding(6, 5, 6, 5);
            txt_password.Multiline = true;
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(476, 51);
            txt_password.TabIndex = 11;
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.None;
            txt_username.Location = new Point(276, 280);
            txt_username.Margin = new Padding(6, 5, 6, 5);
            txt_username.Multiline = true;
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(476, 51);
            txt_username.TabIndex = 10;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // btn_signup
            // 
            btn_signup.Anchor = AnchorStyles.None;
            btn_signup.BackColor = Color.Maroon;
            btn_signup.FlatAppearance.BorderSize = 0;
            btn_signup.FlatStyle = FlatStyle.Flat;
            btn_signup.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            btn_signup.ForeColor = Color.White;
            btn_signup.Location = new Point(276, 795);
            btn_signup.Margin = new Padding(6, 5, 6, 5);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(476, 51);
            btn_signup.TabIndex = 9;
            btn_signup.Text = "Sign up";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // lbl_Password
            // 
            lbl_Password.Anchor = AnchorStyles.None;
            lbl_Password.AutoSize = true;
            lbl_Password.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Password.ForeColor = Color.Maroon;
            lbl_Password.Location = new Point(276, 610);
            lbl_Password.Margin = new Padding(6, 0, 6, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(158, 42);
            lbl_Password.TabIndex = 8;
            lbl_Password.Text = "Password";
            // 
            // lbl_UserName
            // 
            lbl_UserName.Anchor = AnchorStyles.None;
            lbl_UserName.AutoSize = true;
            lbl_UserName.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_UserName.ForeColor = Color.Maroon;
            lbl_UserName.Location = new Point(276, 233);
            lbl_UserName.Margin = new Padding(6, 0, 6, 0);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(167, 42);
            lbl_UserName.TabIndex = 7;
            lbl_UserName.Text = "Username";
            // 
            // txt_ph
            // 
            txt_ph.Anchor = AnchorStyles.None;
            txt_ph.Location = new Point(276, 531);
            txt_ph.Margin = new Padding(6, 5, 6, 5);
            txt_ph.Multiline = true;
            txt_ph.Name = "txt_ph";
            txt_ph.Size = new Size(476, 51);
            txt_ph.TabIndex = 16;
            // 
            // txt_email
            // 
            txt_email.Anchor = AnchorStyles.None;
            txt_email.Location = new Point(276, 388);
            txt_email.Margin = new Padding(6, 5, 6, 5);
            txt_email.Multiline = true;
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(476, 51);
            txt_email.TabIndex = 15;
            // 
            // lbl_ph
            // 
            lbl_ph.Anchor = AnchorStyles.None;
            lbl_ph.AutoSize = true;
            lbl_ph.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ph.ForeColor = Color.Maroon;
            lbl_ph.Location = new Point(276, 484);
            lbl_ph.Margin = new Padding(6, 0, 6, 0);
            lbl_ph.Name = "lbl_ph";
            lbl_ph.Size = new Size(166, 42);
            lbl_ph.TabIndex = 14;
            lbl_ph.Text = "Phone no.";
            lbl_ph.Click += lbl_ph_Click;
            // 
            // lbl_email
            // 
            lbl_email.Anchor = AnchorStyles.None;
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Times New Roman", 13.875F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_email.ForeColor = Color.Maroon;
            lbl_email.Location = new Point(276, 341);
            lbl_email.Margin = new Padding(6, 0, 6, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(104, 42);
            lbl_email.TabIndex = 13;
            lbl_email.Text = "Email";
            // 
            // signup_panel
            // 
            signup_panel.Anchor = AnchorStyles.None;
            signup_panel.Controls.Add(signup_logo);
            signup_panel.Controls.Add(btn_signup);
            signup_panel.Controls.Add(lbl_ph);
            signup_panel.Controls.Add(txt_ph);
            signup_panel.Controls.Add(lbl_email);
            signup_panel.Controls.Add(txt_username);
            signup_panel.Controls.Add(txt_email);
            signup_panel.Controls.Add(lbl_Password);
            signup_panel.Controls.Add(lbl_UserName);
            signup_panel.Controls.Add(checkbox);
            signup_panel.Controls.Add(txt_password);
            signup_panel.Location = new Point(230, -70);
            signup_panel.Name = "signup_panel";
            signup_panel.Size = new Size(1000, 1000);
            signup_panel.TabIndex = 17;
            // 
            // signup_logo
            // 
            signup_logo.Image = (Image)resources.GetObject("signup_logo.Image");
            signup_logo.Location = new Point(0, 0);
            signup_logo.Name = "signup_logo";
            signup_logo.Size = new Size(200, 200);
            signup_logo.SizeMode = PictureBoxSizeMode.StretchImage;
            signup_logo.TabIndex = 17;
            signup_logo.TabStop = false;
            // 
            // SignupForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.cosmin_grosu_tNYNXI0whXs_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1389, 771);
            Controls.Add(signup_panel);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "SignupForm";
            Text = "SignupForm";
            WindowState = FormWindowState.Maximized;
            Load += SignupForm_Load;
            signup_panel.ResumeLayout(false);
            signup_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)signup_logo).EndInit();
            ResumeLayout(false);
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
        private Panel signup_panel;
        private PictureBox signup_logo;
    }
}