namespace My_Parking
{
    partial class ViewPaymentsForm
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPayments
            // 
            dataGridViewPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPayments.Location = new Point(12, 12);
            dataGridViewPayments.Name = "dataGridViewPayments";
            dataGridViewPayments.RowTemplate.Height = 25;
            dataGridViewPayments.Size = new Size(762, 385);
            dataGridViewPayments.TabIndex = 0;
            dataGridViewPayments.CellContentClick += dataGridViewPayments_CellContentClick;
            // 
            // ViewPaymentsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewPayments);
            Name = "ViewPaymentsForm";
            Text = "ViewPaymentsForm";
            Load += ViewPaymentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPayments).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPayments;
    }
}