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
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Location = new Point(59, 247);
            lbl_username.Margin = new Padding(7, 0, 7, 0);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(127, 31);
            lbl_username.TabIndex = 0;
            lbl_username.Text = "UserName";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(59, 292);
            txt_username.Margin = new Padding(7, 6, 7, 6);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(1405, 39);
            txt_username.TabIndex = 1;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(59, 399);
            txt_email.Margin = new Padding(7, 6, 7, 6);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(1405, 39);
            txt_email.TabIndex = 3;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(59, 352);
            lbl_email.Margin = new Padding(7, 0, 7, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(78, 31);
            lbl_email.TabIndex = 2;
            lbl_email.Text = "Email";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(59, 506);
            txt_password.Margin = new Padding(7, 6, 7, 6);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(1405, 39);
            txt_password.TabIndex = 5;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Location = new Point(59, 470);
            lbl_password.Margin = new Padding(7, 0, 7, 0);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(117, 31);
            lbl_password.TabIndex = 4;
            lbl_password.Text = "Password";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(59, 607);
            txt_phone.Margin = new Padding(7, 6, 7, 6);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(1405, 39);
            txt_phone.TabIndex = 7;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(63, 570);
            lbl_phone.Margin = new Padding(7, 0, 7, 0);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(125, 31);
            lbl_phone.TabIndex = 6;
            lbl_phone.Text = "Phone no.";
            // 
            // btn_saveEdits
            // 
            btn_saveEdits.BackColor = Color.Green;
            btn_saveEdits.FlatAppearance.BorderSize = 0;
            btn_saveEdits.FlatStyle = FlatStyle.Flat;
            btn_saveEdits.ForeColor = Color.White;
            btn_saveEdits.Location = new Point(59, 675);
            btn_saveEdits.Margin = new Padding(7, 6, 7, 6);
            btn_saveEdits.Name = "btn_saveEdits";
            btn_saveEdits.Size = new Size(1405, 71);
            btn_saveEdits.TabIndex = 8;
            btn_saveEdits.Text = "Save Edits";
            btn_saveEdits.UseVisualStyleBackColor = false;
            btn_saveEdits.Click += btn_saveEdits_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.DarkRed;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.ForeColor = SystemColors.Control;
            btn_delete.Location = new Point(63, 776);
            btn_delete.Margin = new Padding(7, 6, 7, 6);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(1402, 68);
            btn_delete.TabIndex = 9;
            btn_delete.Text = "Delete Account";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(59, 68);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(523, 85);
            label1.TabIndex = 10;
            label1.Text = "Account Setting";
            // 
            // AccountSettingsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 923);
            Controls.Add(label1);
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
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
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
        private Label label1;
    }
}