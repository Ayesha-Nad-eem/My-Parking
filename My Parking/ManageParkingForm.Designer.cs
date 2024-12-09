using Microsoft.Web.WebView2.WinForms;
using System;
using System.Windows.Forms;
namespace My_Parking
{
    partial class ManageParkingForm
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
            btn_remove = new Button();
            btn_edit = new Button();
            btn_add = new Button();
            btn_exit = new Button();
            panelContainer = new Panel();
            SuspendLayout();
            // 
            // btn_view
            // 
            btn_view.Location = new Point(26, 34);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(149, 46);
            btn_view.TabIndex = 1;
            btn_view.Text = "View Parking Areas";
            btn_view.UseVisualStyleBackColor = true;
            btn_view.Click += btn_view_Click;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(26, 261);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(149, 46);
            btn_remove.TabIndex = 2;
            btn_remove.Text = "Remove Parking Area";
            btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            btn_edit.Location = new Point(26, 187);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(149, 46);
            btn_edit.TabIndex = 3;
            btn_edit.Text = "Edit Parking Area";
            btn_edit.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(26, 111);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(149, 46);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add Parking Area";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(26, 338);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(149, 46);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(198, 22);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(590, 376);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panelViewParking_Paint;
            // 
            // ManageParkingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            Controls.Add(btn_exit);
            Controls.Add(btn_add);
            Controls.Add(btn_edit);
            Controls.Add(btn_remove);
            Controls.Add(btn_view);
            Name = "ManageParkingForm";
            Text = "ManageParkingForm";
            Load += ManageParkingForm_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btn_view;
        private Button btn_remove;
        private Button btn_edit;
        private Button btn_add;
        private Button btn_exit;
        private Panel panelContainer;
    }
}