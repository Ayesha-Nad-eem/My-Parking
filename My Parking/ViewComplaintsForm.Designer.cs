namespace My_Parking
{
    partial class ViewComplaintsForm
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
            dataGridViewComplaints = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewComplaints).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewComplaints
            // 
            dataGridViewComplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewComplaints.Location = new Point(115, 12);
            dataGridViewComplaints.Name = "dataGridViewComplaints";
            dataGridViewComplaints.RowTemplate.Height = 25;
            dataGridViewComplaints.Size = new Size(504, 355);
            dataGridViewComplaints.TabIndex = 1;
            // 
            // ViewComplaintsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewComplaints);
            Name = "ViewComplaintsForm";
            Text = "ViewComplaintsForm";
            Load += ViewComplaintsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewComplaints).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewComplaints;
    }
}