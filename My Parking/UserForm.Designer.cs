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
            SuspendLayout();
            // 
            // btn_book
            // 
            btn_book.Location = new Point(21, 51);
            btn_book.Name = "btn_book";
            btn_book.Size = new Size(159, 56);
            btn_book.TabIndex = 0;
            btn_book.Text = "Book Parking Area";
            btn_book.UseVisualStyleBackColor = true;
            btn_book.Click += btn_book_Click;
            // 
            // btn_complain
            // 
            btn_complain.Location = new Point(21, 126);
            btn_complain.Name = "btn_complain";
            btn_complain.Size = new Size(159, 59);
            btn_complain.TabIndex = 1;
            btn_complain.Text = "File Complain";
            btn_complain.UseVisualStyleBackColor = true;
            btn_complain.Click += btn_complain_Click;
            // 
            // btn_settings
            // 
            btn_settings.Location = new Point(21, 212);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(159, 57);
            btn_settings.TabIndex = 2;
            btn_settings.Text = "Account Settings";
            btn_settings.UseVisualStyleBackColor = true;
            btn_settings.Click += btn_settings_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(21, 298);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(159, 57);
            btn_exit.TabIndex = 3;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(191, 11);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(710, 392);
            panelContainer.TabIndex = 4;
            panelContainer.Paint += panelUserForm_Paint;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 415);
            Controls.Add(panelContainer);
            Controls.Add(btn_exit);
            Controls.Add(btn_settings);
            Controls.Add(btn_complain);
            Controls.Add(btn_book);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btn_book;
        private Button btn_complain;
        private Button btn_settings;
        private Button btn_exit;
        private Panel panelContainer;
    }
}