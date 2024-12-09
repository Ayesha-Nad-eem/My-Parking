namespace My_Parking
{
    partial class RemoveParkingForm
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
            dataGridViewParkings = new DataGridView();
            btn_remove = new Button();
            lbl_ID = new Label();
            txt_ID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkings).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewParkings
            // 
            dataGridViewParkings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParkings.Location = new Point(12, 12);
            dataGridViewParkings.Name = "dataGridViewParkings";
            dataGridViewParkings.RowTemplate.Height = 25;
            dataGridViewParkings.Size = new Size(701, 355);
            dataGridViewParkings.TabIndex = 0;
            // 
            // btn_remove
            // 
            btn_remove.Location = new Point(570, 388);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(75, 23);
            btn_remove.TabIndex = 1;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(187, 392);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(18, 15);
            lbl_ID.TabIndex = 2;
            lbl_ID.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(264, 389);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(202, 23);
            txt_ID.TabIndex = 3;
            // 
            // RemoveParkingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 440);
            Controls.Add(txt_ID);
            Controls.Add(lbl_ID);
            Controls.Add(btn_remove);
            Controls.Add(dataGridViewParkings);
            Name = "RemoveParkingForm";
            Text = "RemoveParkingForm";
            Load += RemoveParkingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewParkings;
        private Button btn_remove;
        private Label lbl_ID;
        private TextBox txt_ID;
    }
}