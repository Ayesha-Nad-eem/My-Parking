namespace My_Parking
{
    partial class UserForm
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
            btn_book = new Button();
            btn_complain = new Button();
            btn_settings = new Button();
            btn_exit = new Button();
            panelContainer = new Panel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_book
            // 
            btn_book.BackColor = Color.Maroon;
            btn_book.FlatAppearance.BorderSize = 0;
            btn_book.FlatStyle = FlatStyle.Flat;
            btn_book.Location = new Point(16, 351);
            btn_book.Margin = new Padding(7, 6, 7, 6);
            btn_book.Name = "btn_book";
            btn_book.Size = new Size(340, 115);
            btn_book.TabIndex = 0;
            btn_book.Text = "Book Parking Area";
            btn_book.UseVisualStyleBackColor = false;
            btn_book.Click += btn_book_Click;
            // 
            // btn_complain
            // 
            btn_complain.BackColor = Color.Maroon;
            btn_complain.FlatAppearance.BorderSize = 0;
            btn_complain.FlatStyle = FlatStyle.Flat;
            btn_complain.Location = new Point(17, 488);
            btn_complain.Margin = new Padding(7, 6, 7, 6);
            btn_complain.Name = "btn_complain";
            btn_complain.Size = new Size(340, 122);
            btn_complain.TabIndex = 1;
            btn_complain.Text = "File Complain";
            btn_complain.UseVisualStyleBackColor = false;
            btn_complain.Click += btn_complain_Click;
            // 
            // btn_settings
            // 
            btn_settings.BackColor = Color.Maroon;
            btn_settings.FlatAppearance.BorderSize = 0;
            btn_settings.FlatStyle = FlatStyle.Flat;
            btn_settings.Location = new Point(17, 634);
            btn_settings.Margin = new Padding(7, 6, 7, 6);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(340, 118);
            btn_settings.TabIndex = 2;
            btn_settings.Text = "Account Settings";
            btn_settings.UseVisualStyleBackColor = false;
            btn_settings.Click += btn_settings_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Maroon;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Location = new Point(16, 778);
            btn_exit.Margin = new Padding(7, 6, 7, 6);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(340, 118);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.Transparent;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(372, 0);
            panelContainer.Margin = new Padding(7, 6, 7, 6);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1526, 923);
            panelContainer.TabIndex = 4;
            panelContainer.Paint += panelUserForm_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(btn_exit);
            panel1.Controls.Add(btn_complain);
            panel1.Controls.Add(btn_book);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 923);
            panel1.TabIndex = 0;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 923);
            Controls.Add(panelContainer);
            Controls.Add(btn_settings);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.Control;
            Margin = new Padding(7, 6, 7, 6);
            Name = "UserForm";
            Text = "UserForm";
            WindowState = FormWindowState.Maximized;
            Load += UserForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_book;
        private Button btn_complain;
        private Button btn_settings;
        private Button btn_exit;
        private Panel panelContainer;
        private Panel panel1;
    }
}