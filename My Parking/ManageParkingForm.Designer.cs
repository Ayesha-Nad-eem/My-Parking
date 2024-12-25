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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_view
            // 
            btn_view.BackColor = Color.Maroon;
            btn_view.FlatAppearance.BorderSize = 0;
            btn_view.FlatStyle = FlatStyle.Flat;
            btn_view.ForeColor = Color.White;
            btn_view.Location = new Point(25, 98);
            btn_view.Margin = new Padding(7, 6, 7, 6);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(320, 95);
            btn_view.TabIndex = 1;
            btn_view.Text = "View Parking Areas";
            btn_view.UseVisualStyleBackColor = false;
            btn_view.Click += btn_view_Click;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Maroon;
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.ForeColor = Color.White;
            btn_remove.Location = new Point(25, 514);
            btn_remove.Margin = new Padding(7, 6, 7, 6);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(320, 95);
            btn_remove.TabIndex = 2;
            btn_remove.Text = "Remove Parking Area";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.Maroon;
            btn_edit.FlatAppearance.BorderSize = 0;
            btn_edit.FlatStyle = FlatStyle.Flat;
            btn_edit.ForeColor = Color.White;
            btn_edit.Location = new Point(25, 370);
            btn_edit.Margin = new Padding(7, 6, 7, 6);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(320, 95);
            btn_edit.TabIndex = 3;
            btn_edit.Text = "Edit Parking Area";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Maroon;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(25, 230);
            btn_add.Margin = new Padding(7, 6, 7, 6);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(320, 95);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add Parking Area";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_exit
            // 
            btn_exit.BackColor = Color.Maroon;
            btn_exit.FlatAppearance.BorderSize = 0;
            btn_exit.FlatStyle = FlatStyle.Flat;
            btn_exit.ForeColor = Color.White;
            btn_exit.Location = new Point(25, 673);
            btn_exit.Margin = new Padding(7, 6, 7, 6);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(320, 95);
            btn_exit.TabIndex = 5;
            btn_exit.Text = "Exit";
            btn_exit.UseVisualStyleBackColor = false;
            btn_exit.Click += btn_exit_Click;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(400, 0);
            panelContainer.Margin = new Padding(7, 6, 7, 6);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1467, 930);
            panelContainer.TabIndex = 0;
            panelContainer.Paint += panelViewParking_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_view);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 930);
            panel1.TabIndex = 0;
            // 
            // ManageParkingForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1867, 930);
            Controls.Add(panelContainer);
            Controls.Add(btn_exit);
            Controls.Add(btn_add);
            Controls.Add(btn_edit);
            Controls.Add(btn_remove);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "ManageParkingForm";
            Text = "ManageParkingForm";
            Load += ManageParkingForm_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btn_view;
        private Button btn_remove;
        private Button btn_edit;
        private Button btn_add;
        private Button btn_exit;
        private Panel panelContainer;
        private Panel panel1;
    }
}