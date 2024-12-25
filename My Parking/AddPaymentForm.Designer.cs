namespace My_Parking
{
    partial class AddPaymentForm
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
            lbl_userID = new Label();
            txt_userID = new TextBox();
            txt_parkingAreaID = new TextBox();
            lbl_parkingAreaID = new Label();
            txt_amount = new TextBox();
            lbl_amount = new Label();
            lbl_paymentMethod = new Label();
            lbl_status = new Label();
            combo_status = new ComboBox();
            btn_save = new Button();
            btn_clear = new Button();
            combo_paymentMethod = new ComboBox();
            SuspendLayout();
            // 
            // lbl_userID
            // 
            lbl_userID.AutoSize = true;
            lbl_userID.Location = new Point(66, 146);
            lbl_userID.Margin = new Padding(7, 0, 7, 0);
            lbl_userID.Name = "lbl_userID";
            lbl_userID.Size = new Size(98, 31);
            lbl_userID.TabIndex = 0;
            lbl_userID.Text = "User ID";
            // 
            // txt_userID
            // 
            txt_userID.Location = new Point(66, 183);
            txt_userID.Margin = new Padding(7, 6, 7, 6);
            txt_userID.Name = "txt_userID";
            txt_userID.Size = new Size(1359, 39);
            txt_userID.TabIndex = 1;
            // 
            // txt_parkingAreaID
            // 
            txt_parkingAreaID.Location = new Point(66, 275);
            txt_parkingAreaID.Margin = new Padding(7, 6, 7, 6);
            txt_parkingAreaID.Name = "txt_parkingAreaID";
            txt_parkingAreaID.Size = new Size(1359, 39);
            txt_parkingAreaID.TabIndex = 3;
            txt_parkingAreaID.TextChanged += txt_parkingAreaID_TextChanged;
            // 
            // lbl_parkingAreaID
            // 
            lbl_parkingAreaID.AutoSize = true;
            lbl_parkingAreaID.Location = new Point(66, 238);
            lbl_parkingAreaID.Margin = new Padding(7, 0, 7, 0);
            lbl_parkingAreaID.Name = "lbl_parkingAreaID";
            lbl_parkingAreaID.Size = new Size(188, 31);
            lbl_parkingAreaID.TabIndex = 2;
            lbl_parkingAreaID.Text = "Parking Area ID";
            // 
            // txt_amount
            // 
            txt_amount.Location = new Point(66, 369);
            txt_amount.Margin = new Padding(7, 6, 7, 6);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(1359, 39);
            txt_amount.TabIndex = 5;
            // 
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.Location = new Point(66, 332);
            lbl_amount.Margin = new Padding(7, 0, 7, 0);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new Size(103, 31);
            lbl_amount.TabIndex = 4;
            lbl_amount.Text = "Amount";
            // 
            // lbl_paymentMethod
            // 
            lbl_paymentMethod.AutoSize = true;
            lbl_paymentMethod.Location = new Point(66, 426);
            lbl_paymentMethod.Margin = new Padding(7, 0, 7, 0);
            lbl_paymentMethod.Name = "lbl_paymentMethod";
            lbl_paymentMethod.Size = new Size(201, 31);
            lbl_paymentMethod.TabIndex = 6;
            lbl_paymentMethod.Text = "Payment Method";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(66, 518);
            lbl_status.Margin = new Padding(7, 0, 7, 0);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(81, 31);
            lbl_status.TabIndex = 8;
            lbl_status.Text = "Status";
            // 
            // combo_status
            // 
            combo_status.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_status.FormattingEnabled = true;
            combo_status.Items.AddRange(new object[] { "Pending", "Paid", "Cancelled" });
            combo_status.Location = new Point(66, 555);
            combo_status.Margin = new Padding(7, 6, 7, 6);
            combo_status.Name = "combo_status";
            combo_status.Size = new Size(1359, 39);
            combo_status.TabIndex = 9;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Green;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(66, 635);
            btn_save.Margin = new Padding(7, 6, 7, 6);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(1359, 60);
            btn_save.TabIndex = 10;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(192, 0, 0);
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(66, 707);
            btn_clear.Margin = new Padding(7, 6, 7, 6);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(1359, 60);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // combo_paymentMethod
            // 
            combo_paymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_paymentMethod.FormattingEnabled = true;
            combo_paymentMethod.Items.AddRange(new object[] { "Cash", "Online Payment", "Others" });
            combo_paymentMethod.Location = new Point(66, 463);
            combo_paymentMethod.Margin = new Padding(7, 6, 7, 6);
            combo_paymentMethod.Name = "combo_paymentMethod";
            combo_paymentMethod.Size = new Size(1359, 39);
            combo_paymentMethod.TabIndex = 12;
            // 
            // AddPaymentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 852);
            Controls.Add(combo_paymentMethod);
            Controls.Add(btn_clear);
            Controls.Add(btn_save);
            Controls.Add(combo_status);
            Controls.Add(lbl_status);
            Controls.Add(lbl_paymentMethod);
            Controls.Add(txt_amount);
            Controls.Add(lbl_amount);
            Controls.Add(txt_parkingAreaID);
            Controls.Add(lbl_parkingAreaID);
            Controls.Add(txt_userID);
            Controls.Add(lbl_userID);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "AddPaymentForm";
            Text = "AddPaymentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_userID;
        private TextBox txt_userID;
        private TextBox txt_parkingAreaID;
        private Label lbl_parkingAreaID;
        private TextBox txt_amount;
        private Label lbl_amount;
        private Label lbl_paymentMethod;
        private Label lbl_status;
        private ComboBox combo_status;
        private Button btn_save;
        private Button btn_clear;
        private ComboBox combo_paymentMethod;
    }
}