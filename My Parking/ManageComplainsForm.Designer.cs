namespace My_Parking
{
    partial class ManageComplainsForm
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
            btn_viewComplains = new Button();
            btn_updateStatus = new Button();
            btn_exit = new Button();
            panelContainer = new Panel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_viewComplains
            // 
            btn_viewComplains.BackColor = Color.Maroon;
            btn_viewComplains.FlatAppearance.BorderSize = 0;
            btn_viewComplains.FlatStyle = FlatStyle.Flat;
            btn_viewComplains.ForeColor = Color.White;
            btn_viewComplains.Location = new Point(26, 389);
            btn_viewComplains.Margin = new Padding(7, 6, 7, 6);
            btn_viewComplains.Name = "btn_viewComplains";
            btn_viewComplains.Size = new Size(320, 87);
            btn_viewComplains.TabIndex = 0;
            btn_viewComplains.Text = "View Complains";
            btn_viewComplains.UseVisualStyleBackColor = false;
            btn_viewComplains.Click += btn_viewComplains_Click;
            // 
            // btn_updateStatus
            // 
            btn_updateStatus.BackColor = Color.Maroon;
            btn_updateStatus.FlatAppearance.BorderSize = 0;
            btn_updateStatus.FlatStyle = FlatStyle.Flat;
            btn_updateStatus.ForeColor = Color.White;
            btn_updateStatus.Location = new Point(26, 505);
            btn_updateStatus.Margin = new Padding(7, 6, 7, 6);
            btn_updateStatus.Name = "btn_updateStatus";
            btn_updateStatus.Size = new Size(320, 87);
            btn_updateStatus.TabIndex = 1;
            btn_updateStatus.Text = "Update Status";
            btn_updateStatus.UseVisualStyleBackColor = false;
            btn_updateStatus.Click += btn_updateStatus_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Maroon;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(26, 632);
            btn_exit.Margin = new Padding(7, 6, 7, 6);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(320, 87);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(377, 0);
            panelContainer.Margin = new Padding(7, 6, 7, 6);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1037, 953);
            panelContainer.TabIndex = 3;
            panelContainer.Paint += panelContainer_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_exit);
            panel1.Controls.Add(btn_viewComplains);
            panel1.Controls.Add(btn_updateStatus);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(377, 953);
            panel1.TabIndex = 0;
            // 
            // ManageComplainsForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1414, 953);
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "ManageComplainsForm";
            Text = "ManageComplainsForm";
            WindowState = FormWindowState.Maximized;
            Load += ManageComplainsForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_viewComplains;
        private Button btn_updateStatus;
        private Button btn_exit;
        private Panel panelContainer;
        private Panel panel1;
    }
}