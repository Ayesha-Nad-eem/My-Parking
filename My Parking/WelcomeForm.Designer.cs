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
            SuspendLayout();
            // 
            // btn_mngusrs
            // 
            btn_mngusrs.Location = new Point(29, 36);
            btn_mngusrs.Name = "btn_mngusrs";
            btn_mngusrs.Size = new Size(127, 40);
            btn_mngusrs.TabIndex = 0;
            btn_mngusrs.Text = "Manage Users";
            btn_mngusrs.UseVisualStyleBackColor = true;
            btn_mngusrs.Click += btn_mngusrs_Click;
            // 
            // btn_mngpark
            // 
            btn_mngpark.Location = new Point(29, 101);
            btn_mngpark.Name = "btn_mngpark";
            btn_mngpark.Size = new Size(127, 38);
            btn_mngpark.TabIndex = 1;
            btn_mngpark.Text = "Manage Parkings";
            btn_mngpark.UseVisualStyleBackColor = true;
            btn_mngpark.Click += btn_mngpark_Click;
            // 
            // btn_mngpay
            // 
            btn_mngpay.Location = new Point(29, 173);
            btn_mngpay.Name = "btn_mngpay";
            btn_mngpay.Size = new Size(127, 38);
            btn_mngpay.TabIndex = 2;
            btn_mngpay.Text = "Manage Payments";
            btn_mngpay.UseVisualStyleBackColor = true;
            btn_mngpay.Click += button3_Click;
            // 
            // btn_mngcomplains
            // 
            btn_mngcomplains.Location = new Point(29, 243);
            btn_mngcomplains.Name = "btn_mngcomplains";
            btn_mngcomplains.Size = new Size(127, 40);
            btn_mngcomplains.TabIndex = 3;
            btn_mngcomplains.Text = "Manage Complaints";
            btn_mngcomplains.UseVisualStyleBackColor = true;
            btn_mngcomplains.Click += btn_mngcomplains_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(29, 308);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(127, 38);
            btn_exit.TabIndex = 4;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click_1;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 411);
            Controls.Add(btn_exit);
            Controls.Add(btn_mngcomplains);
            Controls.Add(btn_mngpay);
            Controls.Add(btn_mngpark);
            Controls.Add(btn_mngusrs);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            Load += WelcomeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_mngusrs;
        private Button btn_mngpark;
        private Button btn_mngpay;
        private Button btn_mngcomplains;
        private Button btn_exit;

    }
}