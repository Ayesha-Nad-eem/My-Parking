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
            dataGridViewParkings.Location = new Point(16, 27);
            dataGridViewParkings.Margin = new Padding(7, 6, 7, 6);
            dataGridViewParkings.Name = "dataGridViewParkings";
            dataGridViewParkings.RowHeadersWidth = 82;
            dataGridViewParkings.RowTemplate.Height = 25;
            dataGridViewParkings.Size = new Size(1494, 578);
            dataGridViewParkings.TabIndex = 0;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(492, 678);
            lbl_ID.Margin = new Padding(7, 0, 7, 0);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(41, 31);
            lbl_ID.TabIndex = 1;
            lbl_ID.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(547, 675);
            txt_ID.Margin = new Padding(7, 6, 7, 6);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(296, 39);
            txt_ID.TabIndex = 2;
            // 
            // btn_confirmBooking
            // 
            btn_confirmBooking.BackColor = Color.Green;
            btn_confirmBooking.FlatAppearance.BorderSize = 0;
            btn_confirmBooking.FlatStyle = FlatStyle.Flat;
            btn_confirmBooking.ForeColor = SystemColors.Control;
            btn_confirmBooking.Location = new Point(547, 787);
            btn_confirmBooking.Margin = new Padding(7, 6, 7, 6);
            btn_confirmBooking.Name = "btn_confirmBooking";
            btn_confirmBooking.Size = new Size(241, 82);
            btn_confirmBooking.TabIndex = 3;
            btn_confirmBooking.Text = "Confirm Booking";
            btn_confirmBooking.UseVisualStyleBackColor = false;
            btn_confirmBooking.Click += btn_confirmBooking_Click;
            // 
            // BookParkingForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 923);
            Controls.Add(btn_confirmBooking);
            Controls.Add(txt_ID);
            Controls.Add(lbl_ID);
            Controls.Add(dataGridViewParkings);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
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