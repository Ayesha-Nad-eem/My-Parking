namespace My_Parking
{
    partial class DeletePaymentForm
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
            dataGridViewPayments = new DataGridView();
            btn_Delete = new Button();
            lbl_ID = new Label();
            txt_ID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayments.Location = new Point(25, 6);
            dataGridViewPayments.Margin = new Padding(7, 6, 7, 6);
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.RowHeadersWidth = 82;
            dataGridViewPayments.RowTemplate.Height = 25;
            dataGridViewPayments.Size = new Size(1485, 676);
            dataGridViewPayments.TabIndex = 1;
            // 
            // btn_Delete
            // 
            btn_Delete.BackColor = Color.FromArgb(192, 0, 0);
            btn_Delete.FlatAppearance.BorderSize = 0;
            btn_Delete.FlatStyle = FlatStyle.Flat;
            btn_Delete.ForeColor = Color.White;
            btn_Delete.Location = new Point(456, 811);
            btn_Delete.Margin = new Padding(7, 6, 7, 6);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(260, 75);
            btn_Delete.TabIndex = 2;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = false;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(385, 749);
            lbl_ID.Margin = new Padding(7, 0, 7, 0);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(41, 31);
            lbl_ID.TabIndex = 3;
            lbl_ID.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(456, 742);
            txt_ID.Margin = new Padding(7, 6, 7, 6);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(332, 39);
            txt_ID.TabIndex = 4;
            // 
            // DeletePaymentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 923);
            Controls.Add(txt_ID);
            Controls.Add(lbl_ID);
            Controls.Add(btn_Delete);
            Controls.Add(dataGridViewPayments);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "DeletePaymentForm";
            Text = "DeletePaymentForm";
            Load += DeletePaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPayments;
        private Button btn_Delete;
        private Label lbl_ID;
        private TextBox txt_ID;
    }
}