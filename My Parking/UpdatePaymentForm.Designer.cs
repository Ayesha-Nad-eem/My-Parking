namespace My_Parking
{
    partial class UpdatePaymentForm
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
            btn_clear = new Button();
            btn_update = new Button();
            combo_status = new ComboBox();
            lbl_status = new Label();
            txt_ID = new TextBox();
            lbl_id = new Label();
            SuspendLayout();
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(209, 219);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(314, 219);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(75, 23);
            btn_update.TabIndex = 10;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // combo_status
            // 
            combo_status.AllowDrop = true;
            combo_status.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_status.FormattingEnabled = true;
            combo_status.Items.AddRange(new object[] { "Pending", "Paid", "Cancelled" });
            combo_status.Location = new Point(268, 153);
            combo_status.Name = "combo_status";
            combo_status.Size = new Size(121, 23);
            combo_status.TabIndex = 9;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(185, 156);
            lbl_status.Name = "lbl_status";
            lbl_status.RightToLeft = RightToLeft.Yes;
            lbl_status.Size = new Size(39, 15);
            lbl_status.TabIndex = 8;
            lbl_status.Text = "Status";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(268, 75);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(121, 23);
            txt_ID.TabIndex = 7;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(198, 78);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(17, 15);
            lbl_id.TabIndex = 6;
            lbl_id.Text = "Id";
            // 
            // UpdatePaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 450);
            Controls.Add(btn_clear);
            Controls.Add(btn_update);
            Controls.Add(combo_status);
            Controls.Add(lbl_status);
            Controls.Add(txt_ID);
            Controls.Add(lbl_id);
            Name = "UpdatePaymentForm";
            Text = "UpdatePaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_clear;
        private Button btn_update;
        private ComboBox combo_status;
        private Label lbl_status;
        private TextBox txt_ID;
        private Label lbl_id;
    }
}