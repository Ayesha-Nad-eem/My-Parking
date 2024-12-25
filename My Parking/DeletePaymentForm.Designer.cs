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
            dataGridViewPayments.Location = new Point(12, 3);
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.RowTemplate.Height = 25;
            dataGridViewPayments.Size = new Size(733, 327);
            dataGridViewPayments.TabIndex = 1;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(576, 359);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(121, 36);
            btn_Delete.TabIndex = 2;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(351, 370);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(18, 15);
            lbl_ID.TabIndex = 3;
            lbl_ID.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(387, 367);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(157, 23);
            txt_ID.TabIndex = 4;
            // 
            // DeletePaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_ID);
            Controls.Add(lbl_ID);
            Controls.Add(btn_Delete);
            Controls.Add(dataGridViewPayments);
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