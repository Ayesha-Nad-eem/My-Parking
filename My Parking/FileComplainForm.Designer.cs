namespace My_Parking
{
    partial class FileComplainForm
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
            txt_complainDescription = new TextBox();
            btn_submitComplain = new Button();
            SuspendLayout();
            // 
            // txt_complainDescription
            // 
            txt_complainDescription.BorderStyle = BorderStyle.FixedSingle;
            txt_complainDescription.Location = new Point(141, 57);
            txt_complainDescription.Margin = new Padding(7, 6, 7, 6);
            txt_complainDescription.Multiline = true;
            txt_complainDescription.Name = "txt_complainDescription";
            txt_complainDescription.Size = new Size(1182, 511);
            txt_complainDescription.TabIndex = 0;
            // 
            // btn_submitComplain
            // 
            btn_submitComplain.BackColor = Color.Maroon;
            btn_submitComplain.FlatAppearance.BorderSize = 0;
            btn_submitComplain.FlatStyle = FlatStyle.Flat;
            btn_submitComplain.ForeColor = Color.White;
            btn_submitComplain.Location = new Point(1061, 616);
            btn_submitComplain.Margin = new Padding(7, 6, 7, 6);
            btn_submitComplain.Name = "btn_submitComplain";
            btn_submitComplain.Size = new Size(262, 80);
            btn_submitComplain.TabIndex = 1;
            btn_submitComplain.Text = "Submit Complaint";
            btn_submitComplain.UseVisualStyleBackColor = false;
            btn_submitComplain.Click += btn_submitComplain_Click;
            // 
            // FileComplainForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 923);
            Controls.Add(btn_submitComplain);
            Controls.Add(txt_complainDescription);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "FileComplainForm";
            Text = "FileComplainForm";
            Load += FileComplainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_complainDescription;
        private Button btn_submitComplain;
    }
}