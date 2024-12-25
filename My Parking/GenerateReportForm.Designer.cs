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
            dateTimePickerStartDate.Location = new Point(276, 40);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(207, 23);
            dateTimePickerStartDate.TabIndex = 0;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(276, 82);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(207, 23);
            dateTimePickerEndDate.TabIndex = 1;
            // 
            // lbl_startDate
            // 
            lbl_startDate.AutoSize = true;
            lbl_startDate.Location = new Point(207, 46);
            lbl_startDate.Name = "lbl_startDate";
            lbl_startDate.Size = new Size(58, 15);
            lbl_startDate.TabIndex = 2;
            lbl_startDate.Text = "Start Date";
            // 
            // lbl_endDate
            // 
            lbl_endDate.AutoSize = true;
            lbl_endDate.Location = new Point(207, 88);
            lbl_endDate.Name = "lbl_endDate";
            lbl_endDate.Size = new Size(54, 15);
            lbl_endDate.TabIndex = 3;
            lbl_endDate.Text = "End Date";
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(207, 126);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(39, 15);
            lbl_status.TabIndex = 4;
            lbl_status.Text = "Status";
            // 
            // combo_status
            // 
            combo_status.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_status.FormattingEnabled = true;
            combo_status.Items.AddRange(new object[] { "Pending", "Paid", "Cancelled" });
            combo_status.Location = new Point(276, 123);
            combo_status.Name = "combo_status";
            combo_status.Size = new Size(207, 23);
            combo_status.TabIndex = 5;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(69, 187);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowTemplate.Height = 25;
            dataGridViewReport.Size = new Size(701, 209);
            dataGridViewReport.TabIndex = 6;
            // 
            // btn_report
            // 
            btn_report.Location = new Point(534, 117);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(131, 32);
            btn_report.TabIndex = 7;
            btn_report.Text = "Generate Report";
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // GenerateReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_report);
            Controls.Add(dataGridViewReport);
            Controls.Add(combo_status);
            Controls.Add(lbl_status);
            Controls.Add(lbl_endDate);
            Controls.Add(lbl_startDate);
            Controls.Add(dateTimePickerEndDate);
            Controls.Add(dateTimePickerStartDate);
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