﻿namespace My_Parking
{
    partial class UpdateComplainForm
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
            lbl_id = new Label();
            txt_ID = new TextBox();
            lbl_status = new Label();
            combo_status = new ComboBox();
            btn_update = new Button();
            btn_clear = new Button();
            SuspendLayout();
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(232, 73);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(17, 15);
            lbl_id.TabIndex = 0;
            lbl_id.Text = "Id";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(302, 70);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(121, 23);
            txt_ID.TabIndex = 1;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(219, 151);
            lbl_status.Name = "lbl_status";
            lbl_status.RightToLeft = RightToLeft.Yes;
            lbl_status.Size = new Size(39, 15);
            lbl_status.TabIndex = 2;
            lbl_status.Text = "Status";
            // 
            // combo_status
            // 
            combo_status.AllowDrop = true;
            combo_status.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_status.FormattingEnabled = true;
            combo_status.Items.AddRange(new object[] { "Pending", "Resolved", "Dismissed" });
            combo_status.Location = new Point(302, 148);
            combo_status.Name = "combo_status";
            combo_status.Size = new Size(121, 23);
            combo_status.TabIndex = 3;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(348, 214);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 4;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(243, 214);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // UpdateComplainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_clear);
            Controls.Add(btn_update);
            Controls.Add(combo_status);
            Controls.Add(lbl_status);
            Controls.Add(txt_ID);
            Controls.Add(lbl_id);
            Name = "UpdateComplainForm";
            Text = "UpdateComplainForm";
            Load += UpdateComplainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_id;
        private TextBox txt_ID;
        private Label lbl_status;
        private ComboBox combo_status;
        private Button btn_update;
        private Button btn_clear;
    }
}