namespace My_Parking
{
    partial class BookParkingForm
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
            lbl_ID = new Label();
            txt_ID = new TextBox();
            btn_confirmBooking = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkings).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewParkings
            // 
            dataGridViewParkings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParkings.Location = new Point(22, 12);
            dataGridViewParkings.Name = "dataGridViewParkings";
            dataGridViewParkings.RowTemplate.Height = 25;
            dataGridViewParkings.Size = new Size(783, 280);
            dataGridViewParkings.TabIndex = 0;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(266, 332);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(18, 15);
            lbl_ID.TabIndex = 1;
            lbl_ID.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(314, 329);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(140, 23);
            txt_ID.TabIndex = 2;
            // 
            // btn_confirmBooking
            // 
            btn_confirmBooking.Location = new Point(518, 321);
            btn_confirmBooking.Name = "btn_confirmBooking";
            btn_confirmBooking.Size = new Size(131, 37);
            btn_confirmBooking.TabIndex = 3;
            btn_confirmBooking.Text = "Confirm Booking";
            btn_confirmBooking.UseVisualStyleBackColor = true;
            btn_confirmBooking.Click += btn_confirmBooking_Click;
            // 
            // BookParkingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 448);
            Controls.Add(btn_confirmBooking);
            Controls.Add(txt_ID);
            Controls.Add(lbl_ID);
            Controls.Add(dataGridViewParkings);
            Name = "BookParkingForm";
            Text = "BookParkingForm";
            Load += BookParkingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkings).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewParkings;
        private Label lbl_ID;
        private TextBox txt_ID;
        private Button btn_confirmBooking;
    }
}