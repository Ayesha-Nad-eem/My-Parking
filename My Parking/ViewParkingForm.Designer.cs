﻿namespace My_Parking
{
    partial class ViewParkingForm
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkings).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewParkings
            // 
            dataGridViewParkings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewParkings.Location = new Point(2, 3);
            dataGridViewParkings.Name = "dataGridViewParkings";
            dataGridViewParkings.RowTemplate.Height = 25;
            dataGridViewParkings.Size = new Size(701, 355);
            dataGridViewParkings.TabIndex = 0;
            dataGridViewParkings.CellContentClick += dataGridViewParkings_CellContentClick;
            // 
            // ViewParkingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 401);
            Controls.Add(dataGridViewParkings);
            Name = "ViewParkingForm";
            Text = "ViewParkingForm";
            Load += ViewParkingForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewParkings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewParkings;
    }
}