namespace My_Parking
{
    partial class UpdateComplainForm
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
            lbl_id = new Label();
            textBox1 = new TextBox();
            lbl_status = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(219, 73);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(17, 15);
            lbl_id.TabIndex = 0;
            lbl_id.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(302, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 1;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Location = new Point(219, 151);
            lbl_status.Name = "lbl_status";
            lbl_status.RightToLeft = RightToLeft.Yes;
            lbl_status.Size = new Size(39, 15);
            lbl_status.TabIndex = 2;
            lbl_status.Text = "Status";
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(302, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // UpdateComplainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(lbl_status);
            Controls.Add(textBox1);
            Controls.Add(lbl_id);
            Name = "UpdateComplainForm";
            Text = "UpdateComplainForm";
            Load += UpdateComplainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_id;
        private TextBox textBox1;
        private Label lbl_status;
        private ComboBox comboBox1;
    }
}