namespace My_Parking
{
    partial class ManagePaymentsForm
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
            btn_delete = new Button();
            btn_update = new Button();
            btn_report = new Button();
            btn_exit = new Button();
            panelContainer = new Panel();
            SuspendLayout();
            // 
            // btn_view
            // 
            btn_view.Location = new Point(12, 66);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(118, 43);
            btn_view.TabIndex = 0;
            btn_view.Text = "View Payments";
            btn_view.UseVisualStyleBackColor = true;
            btn_view.Click += btn_view_Click;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(12, 124);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(118, 42);
            btn_add.TabIndex = 1;
            btn_add.Text = "Add Payment";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(12, 182);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(118, 42);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "Delete Payment";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(12, 241);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(118, 40);
            btn_update.TabIndex = 3;
            btn_update.Text = "Update Status";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_report
            // 
            btn_report.Location = new Point(12, 300);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(118, 41);
            btn_report.TabIndex = 4;
            btn_report.Text = "Generate Report";
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(12, 359);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(118, 40);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(146, 6);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(766, 426);
            panelContainer.TabIndex = 6;
            // 
            // ManagePaymentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 444);
            Controls.Add(panelContainer);
            Controls.Add(btn_exit);
            Controls.Add(btn_report);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(btn_view);
            Name = "ManagePaymentsForm";
            Text = "ManagePaymentsForm";
            Load += ManagePaymentsForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_view;
        private Button btn_add;
        private Button btn_delete;
        private Button btn_update;
        private Button btn_report;
        private Button btn_exit;
        private Panel panelContainer;
    }
}