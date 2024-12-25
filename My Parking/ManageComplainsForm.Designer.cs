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
            SuspendLayout();
            // 
            // btn_viewComplains
            // 
            btn_viewComplains.Location = new Point(38, 104);
            btn_viewComplains.Name = "btn_viewComplains";
            btn_viewComplains.Size = new Size(149, 42);
            btn_viewComplains.TabIndex = 0;
            btn_viewComplains.Text = "View Complains";
            btn_viewComplains.UseVisualStyleBackColor = true;
            btn_viewComplains.Click += btn_viewComplains_Click;
            // 
            // btn_updateStatus
            // 
            btn_updateStatus.Location = new Point(38, 192);
            btn_updateStatus.Name = "btn_updateStatus";
            btn_updateStatus.Size = new Size(149, 42);
            btn_updateStatus.TabIndex = 1;
            btn_updateStatus.Text = "Update Status";
            btn_updateStatus.UseVisualStyleBackColor = true;
            btn_updateStatus.Click += btn_updateStatus_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(38, 279);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(149, 42);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(193, 12);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(647, 426);
            panelContainer.TabIndex = 3;
            // 
            // ManageComplainsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 451);
            Controls.Add(panelContainer);
            Controls.Add(btn_exit);
            Controls.Add(btn_updateStatus);
            Controls.Add(btn_viewComplains);
            Name = "ManageComplainsForm";
            Text = "ManageComplainsForm";
            Load += ManageComplainsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_viewComplains;
        private Button btn_updateStatus;
        private Button btn_exit;
        private Panel panelContainer;
    }
}