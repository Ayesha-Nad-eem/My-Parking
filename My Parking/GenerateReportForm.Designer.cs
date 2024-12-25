namespace My_Parking
{
    partial class GenerateReportForm
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
            dateTimePickerStartDate = new DateTimePicker();
            dateTimePickerEndDate = new DateTimePicker();
            lbl_startDate = new Label();
            lbl_endDate = new Label();
            lbl_status = new Label();
            combo_status = new ComboBox();
            dataGridViewReport = new DataGridView();
            btn_report = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(304, 57);
            dateTimePickerStartDate.Margin = new Padding(7, 6, 7, 6);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(439, 39);
            dateTimePickerStartDate.TabIndex = 0;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(304, 123);
            dateTimePickerEndDate.Margin = new Padding(7, 6, 7, 6);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(439, 39);
            dateTimePickerEndDate.TabIndex = 1;
            // 
            // lbl_startDate
            // 
            lbl_startDate.AutoSize = true;
            lbl_startDate.Location = new Point(166, 63);
            lbl_startDate.Margin = new Padding(7, 0, 7, 0);
            lbl_startDate.Name = "lbl_startDate";
            lbl_startDate.Size = new Size(124, 31);
            lbl_startDate.TabIndex = 2;
            lbl_startDate.Text = "Start Date";
            // 
            // lbl_endDate
            // 
            lbl_endDate.AutoSize = true;
            lbl_endDate.Location = new Point(166, 129);
            lbl_endDate.Margin = new Padding(7, 0, 7, 0);
            lbl_endDate.Name = "lbl_endDate";
            lbl_endDate.Size = new Size(117, 31);
            lbl_endDate.TabIndex = 3;
            lbl_endDate.Text = "End Date";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(166, 191);
            lbl_status.Margin = new Padding(7, 0, 7, 0);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(81, 31);
            lbl_status.TabIndex = 4;
            lbl_status.Text = "Status";
            // 
            // combo_status
            // 
            combo_status.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_status.FormattingEnabled = true;
            combo_status.Items.AddRange(new object[] { "Pending", "Paid", "Cancelled" });
            combo_status.Location = new Point(304, 188);
            combo_status.Margin = new Padding(7, 6, 7, 6);
            combo_status.Name = "combo_status";
            combo_status.Size = new Size(439, 39);
            combo_status.TabIndex = 5;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(16, 374);
            dataGridViewReport.Margin = new Padding(7, 6, 7, 6);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 82;
            dataGridViewReport.RowTemplate.Height = 25;
            dataGridViewReport.Size = new Size(1468, 432);
            dataGridViewReport.TabIndex = 6;
            // 
            // btn_report
            // 
            btn_report.BackColor = Color.Maroon;
            btn_report.FlatAppearance.BorderSize = 0;
            btn_report.FlatStyle = FlatStyle.Flat;
            btn_report.ForeColor = Color.White;
            btn_report.Location = new Point(304, 267);
            btn_report.Margin = new Padding(7, 6, 7, 6);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(280, 66);
            btn_report.TabIndex = 7;
            btn_report.Text = "Generate Report";
            btn_report.UseVisualStyleBackColor = false;
            btn_report.Click += btn_report_Click;
            // 
            // GenerateReportForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 852);
            Controls.Add(btn_report);
            Controls.Add(dataGridViewReport);
            Controls.Add(combo_status);
            Controls.Add(lbl_status);
            Controls.Add(lbl_endDate);
            Controls.Add(lbl_startDate);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(dateTimePickerStartDate);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
            Name = "GenerateReportForm";
            Text = "GenerateReportForm";
            Load += GenerateReportForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerStartDate;
        private DateTimePicker dateTimePickerEndDate;
        private Label lbl_startDate;
        private Label lbl_endDate;
        private Label lbl_status;
        private ComboBox combo_status;
        private DataGridView dataGridViewReport;
        private Button btn_report;
    }
}