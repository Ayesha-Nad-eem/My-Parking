namespace My_Parking
{
    partial class UserPaymentForm
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
            btn_confirm = new Button();
            lbl_paymentMethod = new Label();
            lbl_amount = new Label();
            cmb_paymentMethod = new ComboBox();
            SuspendLayout();
            // 
            // btn_confirm
            // 
            btn_confirm.Location = new Point(184, 184);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(129, 40);
            btn_confirm.TabIndex = 0;
            btn_confirm.Text = "Confirm Payment";
            btn_confirm.UseVisualStyleBackColor = true;
            btn_confirm.Click += button1_Click;
            // 
            // lbl_paymentMethod
            // 
            lbl_paymentMethod.AutoSize = true;
            lbl_paymentMethod.Location = new Point(82, 71);
            lbl_paymentMethod.Name = "lbl_paymentMethod";
            lbl_paymentMethod.Size = new Size(142, 15);
            lbl_paymentMethod.TabIndex = 1;
            lbl_paymentMethod.Text = "Choose Payment Method";
            // 
            // lbl_amount
            // 
            lbl_amount.AutoSize = true;
            lbl_amount.Location = new Point(213, 134);
            lbl_amount.Name = "lbl_amount";
            lbl_amount.Size = new Size(51, 15);
            lbl_amount.TabIndex = 2;
            lbl_amount.Text = "Amount";
            // 
            // cmb_paymentMethod
            // 
            cmb_paymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_paymentMethod.FormattingEnabled = true;
            cmb_paymentMethod.Items.AddRange(new object[] { "Cash", "Online Payment", "Others" });
            cmb_paymentMethod.Location = new Point(275, 68);
            cmb_paymentMethod.Name = "cmb_paymentMethod";
            cmb_paymentMethod.Size = new Size(121, 23);
            cmb_paymentMethod.TabIndex = 3;
            // 
            // UserPaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 306);
            Controls.Add(cmb_paymentMethod);
            Controls.Add(lbl_amount);
            Controls.Add(lbl_paymentMethod);
            Controls.Add(btn_confirm);
            Name = "UserPaymentForm";
            Text = "UserPaymentForm";
            Load += UserPaymentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_confirm;
        private Label lbl_paymentMethod;
        private Label lbl_amount;
        private ComboBox cmb_paymentMethod;
    }
}