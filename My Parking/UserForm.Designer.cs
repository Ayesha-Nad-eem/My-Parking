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
            btn_exit = new Button();
            panelContainer = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_book
            // 
            btn_book.BackColor = Color.Maroon;
            btn_book.FlatAppearance.BorderSize = 0;
            btn_book.FlatStyle = FlatStyle.Flat;
            btn_book.Location = new Point(18, 242);
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
            btn_complain.Location = new Point(19, 379);
            btn_complain.Margin = new Padding(7, 6, 7, 6);
            btn_complain.Name = "btn_complain";
            btn_complain.Size = new Size(340, 122);
            btn_complain.TabIndex = 1;
            btn_complain.Text = "File Complain";
            btn_complain.UseVisualStyleBackColor = false;
            btn_complain.Click += btn_complain_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Maroon;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Location = new Point(18, 669);
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
            panelContainer.Location = new Point(210, 0);
            panelContainer.Margin = new Padding(7, 6, 7, 6);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(528, 351);
            panelContainer.TabIndex = 4;
            panelContainer.Paint += panelUserForm_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 51);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_exit);
            panel1.Controls.Add(btn_complain);
            panel1.Controls.Add(btn_book);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(210, 351);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(18, 526);
            button1.Margin = new Padding(7, 6, 7, 6);
            button1.Name = "button1";
            button1.Size = new Size(340, 118);
            button1.TabIndex = 2;
            button1.Text = "Account Settings";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btn_settings_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 351);
            Controls.Add(panelContainer);
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
        private Button btn_exit;
        private Panel panelContainer;
        private Panel panel1;
        private Button button1;
    }
}