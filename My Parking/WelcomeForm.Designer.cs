namespace My_Parking
{
    partial class WelcomeForm
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
            btn_mngusrs = new Button();
            btn_mngpark = new Button();
            btn_mngpay = new Button();
            btn_mngcomplains = new Button();
            btn_exit = new Button();
            label1 = new Label();
            admin_dashboard_panel = new Panel();
            admin_dashboard_panel.SuspendLayout();
            SuspendLayout();
            // 
            // btn_mngusrs
            // 
            btn_mngusrs.Anchor = AnchorStyles.None;
            btn_mngusrs.BackColor = Color.Maroon;
            btn_mngusrs.FlatAppearance.BorderSize = 0;
            btn_mngusrs.FlatStyle = FlatStyle.Flat;
            btn_mngusrs.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mngusrs.ForeColor = Color.White;
            btn_mngusrs.Location = new Point(25, 169);
            btn_mngusrs.Margin = new Padding(6, 5, 6, 5);
            btn_mngusrs.Name = "btn_mngusrs";
            btn_mngusrs.Size = new Size(500, 84);
            btn_mngusrs.TabIndex = 0;
            btn_mngusrs.Text = "Manage Users";
            btn_mngusrs.UseVisualStyleBackColor = false;
            btn_mngusrs.Click += btn_mngusrs_Click;
            // 
            // btn_mngpark
            // 
            btn_mngpark.Anchor = AnchorStyles.None;
            btn_mngpark.BackColor = Color.Maroon;
            btn_mngpark.FlatAppearance.BorderSize = 0;
            btn_mngpark.FlatStyle = FlatStyle.Flat;
            btn_mngpark.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mngpark.ForeColor = Color.White;
            btn_mngpark.Location = new Point(25, 548);
            btn_mngpark.Margin = new Padding(6, 5, 6, 5);
            btn_mngpark.Name = "btn_mngpark";
            btn_mngpark.Size = new Size(500, 84);
            btn_mngpark.TabIndex = 1;
            btn_mngpark.Text = "Manage Parkings";
            btn_mngpark.UseVisualStyleBackColor = false;
            btn_mngpark.Click += btn_mngpark_Click;
            // 
            // btn_mngpay
            // 
            btn_mngpay.Anchor = AnchorStyles.None;
            btn_mngpay.BackColor = Color.Maroon;
            btn_mngpay.FlatAppearance.BorderSize = 0;
            btn_mngpay.FlatStyle = FlatStyle.Flat;
            btn_mngpay.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mngpay.ForeColor = Color.White;
            btn_mngpay.Location = new Point(25, 295);
            btn_mngpay.Margin = new Padding(6, 5, 6, 5);
            btn_mngpay.Name = "btn_mngpay";
            btn_mngpay.Size = new Size(500, 84);
            btn_mngpay.TabIndex = 2;
            btn_mngpay.Text = "Manage Payments";
            btn_mngpay.UseVisualStyleBackColor = false;
            btn_mngpay.Click += button3_Click;
            // 
            // btn_mngcomplains
            // 
            btn_mngcomplains.Anchor = AnchorStyles.None;
            btn_mngcomplains.BackColor = Color.Maroon;
            btn_mngcomplains.FlatAppearance.BorderSize = 0;
            btn_mngcomplains.FlatStyle = FlatStyle.Flat;
            btn_mngcomplains.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btn_mngcomplains.ForeColor = Color.White;
            btn_mngcomplains.Location = new Point(25, 422);
            btn_mngcomplains.Margin = new Padding(6, 5, 6, 5);
            btn_mngcomplains.Name = "btn_mngcomplains";
            btn_mngcomplains.Size = new Size(500, 84);
            btn_mngcomplains.TabIndex = 3;
            btn_mngcomplains.Text = "Manage Complaints";
            btn_mngcomplains.UseVisualStyleBackColor = false;
            btn_mngcomplains.Click += btn_mngcomplains_Click;
            // 
            // btn_exit
            // 
            btn_exit.Anchor = AnchorStyles.None;
            btn_exit.BackColor = Color.Maroon;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.Font = new Font("Times New Roman", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(25, 675);
            btn_exit.Margin = new Padding(6, 5, 6, 5);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(500, 84);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 19.875F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(58, 84);
            label1.Name = "label1";
            label1.Size = new Size(419, 61);
            label1.TabIndex = 5;
            label1.Text = "Admin Dashboard";
            // 
            // admin_dashboard_panel
            // 
            admin_dashboard_panel.BackColor = Color.Transparent;
            admin_dashboard_panel.Controls.Add(btn_exit);
            admin_dashboard_panel.Controls.Add(btn_mngusrs);
            admin_dashboard_panel.Controls.Add(btn_mngpay);
            admin_dashboard_panel.Controls.Add(btn_mngcomplains);
            admin_dashboard_panel.Controls.Add(btn_mngpark);
            admin_dashboard_panel.Dock = DockStyle.Left;
            admin_dashboard_panel.Location = new Point(0, 0);
            admin_dashboard_panel.Name = "admin_dashboard_panel";
            admin_dashboard_panel.Size = new Size(550, 784);
            admin_dashboard_panel.TabIndex = 6;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.scottie_scheid_olo97u6_j3s_unsplash;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1627, 784);
            Controls.Add(label1);
            Controls.Add(admin_dashboard_panel);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6, 5, 6, 5);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            WindowState = FormWindowState.Maximized;
            Load += WelcomeForm_Load;
            admin_dashboard_panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mngusrs;
        private Button btn_mngpark;
        private Button btn_mngpay;
        private Button btn_mngcomplains;
        private Button btn_exit;
        private Label label1;
        private Panel admin_dashboard_panel;
    }
}