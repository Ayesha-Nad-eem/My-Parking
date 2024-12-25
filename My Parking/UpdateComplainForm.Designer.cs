namespace My_Parking
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
            lbl_id.Location = new Point(505, 298);
            lbl_id.Margin = new Padding(7, 0, 7, 0);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(36, 31);
            lbl_id.TabIndex = 0;
            lbl_id.Text = "Id";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(623, 290);
            txt_ID.Margin = new Padding(7, 6, 7, 6);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(312, 39);
            txt_ID.TabIndex = 1;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(505, 389);
            lbl_status.Margin = new Padding(7, 0, 7, 0);
            lbl_status.Name = "lbl_status";
            lbl_status.RightToLeft = RightToLeft.Yes;
            lbl_status.Size = new Size(81, 31);
            lbl_status.TabIndex = 2;
            lbl_status.Text = "Status";
            // 
            // combo_status
            // 
            combo_status.AllowDrop = true;
            combo_status.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_status.FormattingEnabled = true;
            combo_status.Items.AddRange(new object[] { "Pending", "Resolved", "Dismissed" });
            combo_status.Location = new Point(623, 386);
            combo_status.Margin = new Padding(7, 6, 7, 6);
            combo_status.Name = "combo_status";
            combo_status.Size = new Size(312, 39);
            combo_status.TabIndex = 3;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Green;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(730, 521);
            btn_update.Margin = new Padding(7, 6, 7, 6);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(205, 74);
            btn_update.TabIndex = 4;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = false;
            btn_update.Click += btn_update_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Gray;
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(505, 521);
            btn_clear.Margin = new Padding(7, 6, 7, 6);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(205, 74);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // UpdateComplainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1715, 930);
            Controls.Add(btn_clear);
            Controls.Add(btn_update);
            Controls.Add(combo_status);
            Controls.Add(lbl_status);
            Controls.Add(txt_ID);
            Controls.Add(lbl_id);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
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