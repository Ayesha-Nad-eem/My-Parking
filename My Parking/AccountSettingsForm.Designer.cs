namespace My_Parking
{
    partial class AccountSettingsForm
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
            lbl_username = new Label();
            txt_username = new TextBox();
            txt_email = new TextBox();
            lbl_email = new Label();
            txt_password = new TextBox();
            lbl_password = new Label();
            txt_phone = new TextBox();
            lbl_phone = new Label();
            btn_saveEdits = new Button();
            btn_delete = new Button();
            SuspendLayout();
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(250, 75);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(62, 15);
            lbl_username.TabIndex = 0;
            lbl_username.Text = "UserName";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(351, 72);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(161, 23);
            txt_username.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(351, 131);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(161, 23);
            txt_email.TabIndex = 3;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(250, 134);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(36, 15);
            lbl_email.TabIndex = 2;
            lbl_email.Text = "Email";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(351, 186);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(161, 23);
            txt_password.TabIndex = 5;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(250, 189);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(57, 15);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Password";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(351, 236);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(161, 23);
            txt_phone.TabIndex = 7;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(250, 239);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(61, 15);
            lbl_phone.TabIndex = 6;
            lbl_phone.Text = "Phone no.";
            // 
            // btn_saveEdits
            // 
            btn_saveEdits.Location = new Point(315, 294);
            btn_saveEdits.Name = "btn_saveEdits";
            btn_saveEdits.Size = new Size(118, 34);
            btn_saveEdits.TabIndex = 8;
            btn_saveEdits.Text = "Save Edits";
            btn_saveEdits.UseVisualStyleBackColor = true;
            btn_saveEdits.Click += btn_saveEdits_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(536, 294);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(118, 34);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete Account";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // AccountSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 466);
            Controls.Add(btn_delete);
            Controls.Add(btn_saveEdits);
            Controls.Add(txt_phone);
            Controls.Add(lbl_phone);
            Controls.Add(txt_password);
            Controls.Add(lbl_password);
            Controls.Add(txt_email);
            Controls.Add(lbl_email);
            Controls.Add(txt_username);
            Controls.Add(lbl_username);
            Name = "AccountSettingsForm";
            Text = "AccountSettingsForm";
            Load += AccountSettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_username;
        private TextBox txt_username;
        private TextBox txt_email;
        private Label lbl_email;
        private TextBox txt_password;
        private Label lbl_password;
        private TextBox txt_phone;
        private Label lbl_phone;
        private Button btn_saveEdits;
        private Button btn_delete;
    }
}