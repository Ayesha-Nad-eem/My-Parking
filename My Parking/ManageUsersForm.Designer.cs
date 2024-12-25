namespace My_Parking
{
    partial class ManageUsersForm
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
            btn_view = new Button();
            btn_add = new Button();
            btn_edit = new Button();
            btn_del = new Button();
            btn_exit = new Button();
            panelView = new Panel();
            dataGridViewUser = new DataGridView();
            panelAdd = new Panel();
            btn_clear = new Button();
            btn_adduser = new Button();
            txt_ph = new TextBox();
            txt_email = new TextBox();
            lbl_ph = new Label();
            lbl_email = new Label();
            txt_password = new TextBox();
            txt_username = new TextBox();
            lbl_Password = new Label();
            lbl_UserName = new Label();
            panelEdit = new Panel();
            txt_IDedit = new TextBox();
            label5 = new Label();
            btn_clearedit = new Button();
            btn_saveedit = new Button();
            txt_phoneedit = new TextBox();
            txt_emailedit = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_passedit = new TextBox();
            txt_nameedit = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panelDefault = new Panel();
            panelDelete = new Panel();
            btn_confirmdel = new Button();
            txt_IDdelete = new TextBox();
            label6 = new Label();
            dataGridViewDelete = new DataGridView();
            panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).BeginInit();
            panelAdd.SuspendLayout();
            panelEdit.SuspendLayout();
            panelDelete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDelete).BeginInit();
            SuspendLayout();
            // 
            // btn_view
            // 
            btn_view.BackColor = Color.Maroon;
            btn_view.FlatAppearance.BorderSize = 0;
            btn_view.FlatStyle = FlatStyle.Flat;
            btn_view.Font = new Font("Times New Roman", 14F);
            btn_view.ForeColor = Color.White;
            btn_view.ImageAlign = ContentAlignment.BottomCenter;
            btn_view.Location = new Point(67, 68);
            btn_view.Margin = new Padding(6, 6, 6, 6);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(277, 98);
            btn_view.TabIndex = 0;
            btn_view.Text = "View Users";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Maroon;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.Font = new Font("Times New Roman", 14F);
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(67, 220);
            btn_add.Margin = new Padding(6, 6, 6, 6);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(277, 98);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add User";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.Maroon;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.Font = new Font("Times New Roman", 13.875F);
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(67, 367);
            btn_edit.Margin = new Padding(6, 6, 6, 6);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(277, 98);
            btn_edit.TabIndex = 2;
            btn_edit.Text = "Edit User";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_del
            // 
            btn_del.BackColor = Color.Maroon;
            btn_del.FlatStyle = FlatStyle.Flat;
            btn_del.Font = new Font("Times New Roman", 13.875F);
            btn_del.ForeColor = Color.White;
            btn_del.Location = new Point(67, 518);
            btn_del.Margin = new Padding(6, 6, 6, 6);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(277, 98);
            btn_del.TabIndex = 3;
            btn_del.Text = "Delete User";
            btn_del.UseVisualStyleBackColor = false;
            btn_del.Click += btn_del_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Maroon;
            btn_exit.Font = new Font("Times New Roman", 13.875F);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(67, 678);
            btn_exit.Margin = new Padding(6, 6, 6, 6);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(277, 98);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // panelView
            // 
            panelView.Controls.Add(dataGridViewUser);
            panelView.Location = new Point(423, 47);
            panelView.Margin = new Padding(6, 6, 6, 6);
            panelView.Name = "panelView";
            panelView.Size = new Size(1196, 774);
            panelView.TabIndex = 5;
            // 
            // dataGridViewUser
            // 
            dataGridViewUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUser.Location = new Point(93, 49);
            dataGridViewUser.Margin = new Padding(6, 6, 6, 6);
            dataGridViewUser.Name = "dataGridViewUser";
            dataGridViewUser.RowHeadersWidth = 82;
            dataGridViewUser.RowTemplate.Height = 25;
            dataGridViewUser.Size = new Size(1001, 527);
            dataGridViewUser.TabIndex = 0;
            dataGridViewUser.CellContentClick += dataGridViewUser_CellContentClick;
            // 
            // panelAdd
            // 
            panelAdd.Controls.Add(btn_clear);
            panelAdd.Controls.Add(btn_adduser);
            panelAdd.Controls.Add(txt_ph);
            panelAdd.Controls.Add(txt_email);
            panelAdd.Controls.Add(lbl_ph);
            panelAdd.Controls.Add(lbl_email);
            panelAdd.Controls.Add(txt_password);
            panelAdd.Controls.Add(txt_username);
            panelAdd.Controls.Add(lbl_Password);
            panelAdd.Controls.Add(lbl_UserName);
            panelAdd.Font = new Font("Times New Roman", 9F);
            panelAdd.Location = new Point(423, 47);
            panelAdd.Margin = new Padding(6, 6, 6, 6);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(1196, 774);
            panelAdd.TabIndex = 7;
            panelAdd.Paint += panelAdd_Paint;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(553, 503);
            btn_clear.Margin = new Padding(6, 6, 6, 6);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(139, 49);
            btn_clear.TabIndex = 26;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_adduser
            // 
            btn_adduser.BackColor = Color.Maroon;
            btn_adduser.FlatAppearance.BorderSize = 0;
            btn_adduser.FlatStyle = FlatStyle.Flat;
            btn_adduser.ForeColor = Color.White;
            btn_adduser.Location = new Point(370, 503);
            btn_adduser.Margin = new Padding(6, 6, 6, 6);
            btn_adduser.Name = "btn_adduser";
            btn_adduser.Size = new Size(139, 49);
            btn_adduser.TabIndex = 25;
            btn_adduser.Text = "Add";
            btn_adduser.UseVisualStyleBackColor = false;
            btn_adduser.Click += btn_adduser_Click;
            // 
            // txt_ph
            // 
            txt_ph.Location = new Point(370, 399);
            txt_ph.Margin = new Padding(6, 6, 6, 6);
            txt_ph.Name = "txt_ph";
            txt_ph.Size = new Size(323, 35);
            txt_ph.TabIndex = 24;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(370, 282);
            txt_email.Margin = new Padding(6, 6, 6, 6);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(323, 35);
            txt_email.TabIndex = 23;
            // 
            // lbl_ph
            // 
            lbl_ph.AutoSize = true;
            lbl_ph.Location = new Point(212, 405);
            lbl_ph.Margin = new Padding(6, 0, 6, 0);
            lbl_ph.Name = "lbl_ph";
            lbl_ph.Size = new Size(109, 27);
            lbl_ph.TabIndex = 22;
            lbl_ph.Text = "Phone no.";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(212, 288);
            lbl_email.Margin = new Padding(6, 0, 6, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(68, 27);
            lbl_email.TabIndex = 21;
            lbl_email.Text = "Email";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(370, 154);
            txt_password.Margin = new Padding(6, 6, 6, 6);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(323, 35);
            txt_password.TabIndex = 20;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(370, 43);
            txt_username.Margin = new Padding(6, 6, 6, 6);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(323, 35);
            txt_username.TabIndex = 19;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(212, 160);
            lbl_Password.Margin = new Padding(6, 0, 6, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(104, 27);
            lbl_Password.TabIndex = 18;
            lbl_Password.Text = "Password";
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Location = new Point(206, 49);
            lbl_UserName.Margin = new Padding(6, 0, 6, 0);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(108, 27);
            lbl_UserName.TabIndex = 17;
            lbl_UserName.Text = "Username";
            // 
            // panelEdit
            // 
            panelEdit.Controls.Add(txt_IDedit);
            panelEdit.Controls.Add(label5);
            panelEdit.Controls.Add(btn_clearedit);
            panelEdit.Controls.Add(btn_saveedit);
            panelEdit.Controls.Add(txt_phoneedit);
            panelEdit.Controls.Add(txt_emailedit);
            panelEdit.Controls.Add(label1);
            panelEdit.Controls.Add(label2);
            panelEdit.Controls.Add(txt_passedit);
            panelEdit.Controls.Add(txt_nameedit);
            panelEdit.Controls.Add(label3);
            panelEdit.Controls.Add(label4);
            panelEdit.Font = new Font("Times New Roman", 9F);
            panelEdit.Location = new Point(423, 47);
            panelEdit.Margin = new Padding(6, 6, 6, 6);
            panelEdit.Name = "panelEdit";
            panelEdit.Size = new Size(1196, 774);
            panelEdit.TabIndex = 8;
            // 
            // txt_IDedit
            // 
            txt_IDedit.Location = new Point(438, 43);
            txt_IDedit.Margin = new Padding(6, 6, 6, 6);
            txt_IDedit.Name = "txt_IDedit";
            txt_IDedit.Size = new Size(323, 35);
            txt_IDedit.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 51);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(37, 27);
            label5.TabIndex = 37;
            label5.Text = "ID";
            // 
            // btn_clearedit
            // 
            btn_clearedit.Location = new Point(622, 589);
            btn_clearedit.Margin = new Padding(6, 6, 6, 6);
            btn_clearedit.Name = "btn_clearedit";
            btn_clearedit.Size = new Size(139, 49);
            btn_clearedit.TabIndex = 36;
            btn_clearedit.Text = "Clear";
            btn_clearedit.UseVisualStyleBackColor = true;
            btn_clearedit.Click += btn_clearedit_Click;
            // 
            // btn_saveedit
            // 
            btn_saveedit.BackColor = Color.Maroon;
            btn_saveedit.FlatAppearance.BorderSize = 0;
            btn_saveedit.FlatStyle = FlatStyle.Flat;
            btn_saveedit.Font = new Font("Times New Roman", 9F);
            btn_saveedit.ForeColor = Color.WhiteSmoke;
            btn_saveedit.Location = new Point(449, 589);
            btn_saveedit.Margin = new Padding(6, 6, 6, 6);
            btn_saveedit.Name = "btn_saveedit";
            btn_saveedit.Size = new Size(139, 49);
            btn_saveedit.TabIndex = 35;
            btn_saveedit.Text = "Save Edit";
            btn_saveedit.UseVisualStyleBackColor = false;
            btn_saveedit.Click += btn_saveedit_Click;
            // 
            // txt_phoneedit
            // 
            txt_phoneedit.Location = new Point(438, 476);
            txt_phoneedit.Margin = new Padding(6, 6, 6, 6);
            txt_phoneedit.Name = "txt_phoneedit";
            txt_phoneedit.Size = new Size(323, 35);
            txt_phoneedit.TabIndex = 34;
            // 
            // txt_emailedit
            // 
            txt_emailedit.Location = new Point(438, 365);
            txt_emailedit.Margin = new Padding(6, 6, 6, 6);
            txt_emailedit.Name = "txt_emailedit";
            txt_emailedit.Size = new Size(323, 35);
            txt_emailedit.TabIndex = 33;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 484);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 27);
            label1.TabIndex = 32;
            label1.Text = "Phone no.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(293, 367);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 27);
            label2.TabIndex = 31;
            label2.Text = "Email";
            // 
            // txt_passedit
            // 
            txt_passedit.Location = new Point(438, 235);
            txt_passedit.Margin = new Padding(6, 6, 6, 6);
            txt_passedit.Name = "txt_passedit";
            txt_passedit.Size = new Size(323, 35);
            txt_passedit.TabIndex = 30;
            // 
            // txt_nameedit
            // 
            txt_nameedit.Location = new Point(438, 130);
            txt_nameedit.Margin = new Padding(6, 6, 6, 6);
            txt_nameedit.Name = "txt_nameedit";
            txt_nameedit.Size = new Size(323, 35);
            txt_nameedit.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(293, 241);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 28;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 130);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(108, 27);
            label4.TabIndex = 27;
            label4.Text = "Username";
            // 
            // panelDefault
            // 
            panelDefault.Location = new Point(423, 47);
            panelDefault.Margin = new Padding(6, 6, 6, 6);
            panelDefault.Name = "panelDefault";
            panelDefault.Size = new Size(1196, 774);
            panelDefault.TabIndex = 6;
            // 
            // panelDelete
            // 
            panelDelete.Controls.Add(btn_confirmdel);
            panelDelete.Controls.Add(txt_IDdelete);
            panelDelete.Controls.Add(label6);
            panelDelete.Controls.Add(dataGridViewDelete);
            panelDelete.Location = new Point(423, 47);
            panelDelete.Margin = new Padding(6, 6, 6, 6);
            panelDelete.Name = "panelDelete";
            panelDelete.Size = new Size(1252, 787);
            panelDelete.TabIndex = 9;
            panelDelete.Paint += panelDelete_Paint;
            // 
            // btn_confirmdel
            // 
            btn_confirmdel.BackColor = Color.Maroon;
            btn_confirmdel.FlatAppearance.BorderSize = 0;
            btn_confirmdel.FlatStyle = FlatStyle.Flat;
            btn_confirmdel.Font = new Font("Times New Roman", 11F);
            btn_confirmdel.ForeColor = Color.White;
            btn_confirmdel.Location = new Point(860, 597);
            btn_confirmdel.Margin = new Padding(6, 6, 6, 6);
            btn_confirmdel.Name = "btn_confirmdel";
            btn_confirmdel.Size = new Size(178, 58);
            btn_confirmdel.TabIndex = 4;
            btn_confirmdel.Text = "Delete";
            btn_confirmdel.UseVisualStyleBackColor = false;
            btn_confirmdel.Click += btn_confirmdel_Click;
            // 
            // txt_IDdelete
            // 
            txt_IDdelete.Location = new Point(409, 614);
            txt_IDdelete.Margin = new Padding(6, 6, 6, 6);
            txt_IDdelete.Name = "txt_IDdelete";
            txt_IDdelete.Size = new Size(297, 39);
            txt_IDdelete.TabIndex = 3;
            txt_IDdelete.TextChanged += txt_IDdelete_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(232, 623);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(155, 32);
            label6.TabIndex = 2;
            label6.Text = "ID to Delete: ";
            // 
            // dataGridViewDelete
            // 
            dataGridViewDelete.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDelete.Location = new Point(100, 19);
            dataGridViewDelete.Margin = new Padding(6, 6, 6, 6);
            dataGridViewDelete.Name = "dataGridViewDelete";
            dataGridViewDelete.RowHeadersWidth = 82;
            dataGridViewDelete.RowTemplate.Height = 25;
            dataGridViewDelete.Size = new Size(1034, 514);
            dataGridViewDelete.TabIndex = 1;
            dataGridViewDelete.CellContentClick += dataGridViewDelete_CellContentClick;
            // 
            // ManageUsersForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1677, 907);
            Controls.Add(panelDelete);
            Controls.Add(panelView);
            Controls.Add(panelEdit);
            Controls.Add(panelAdd);
            Controls.Add(panelDefault);
            Controls.Add(btn_exit);
            Controls.Add(btn_del);
            Controls.Add(btn_edit);
            Controls.Add(btn_add);
            Controls.Add(btn_view);
            Margin = new Padding(6, 6, 6, 6);
            Name = "ManageUsersForm";
            Text = "ManageUsersForm";
            WindowState = FormWindowState.Maximized;
            Load += ManageUsersForm_Load;
            panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUser).EndInit();
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            panelEdit.ResumeLayout(false);
            panelEdit.PerformLayout();
            panelDelete.ResumeLayout(false);
            panelDelete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDelete).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_view;
        private Button btn_add;
        private Button btn_edit;
        private Button btn_del;
        private Button btn_exit;
        private Panel panelView;
        private DataGridView dataGridViewUser;
        private Panel panelDefault;
        private Panel panelAdd;
        private TextBox txt_ph;
        private TextBox txt_email;
        private Label lbl_ph;
        private Label lbl_email;
        private TextBox txt_password;
        private TextBox txt_username;
        private Label lbl_Password;
        private Label lbl_UserName;
        private Button btn_adduser;
        private Button btn_clear;
        private Panel panelEdit;
        private TextBox txt_IDedit;
        private Label label5;
        private Button btn_clearedit;
        private Button btn_saveedit;
        private TextBox txt_phoneedit;
        private TextBox txt_emailedit;
        private Label label1;
        private Label label2;
        private TextBox txt_passedit;
        private TextBox txt_nameedit;
        private Label label3;
        private Label label4;
        private Panel panelDelete;
        private DataGridView dataGridViewDelete;
        private Button btn_confirmdel;
        private TextBox txt_IDdelete;
        private Label label6;
    }
}