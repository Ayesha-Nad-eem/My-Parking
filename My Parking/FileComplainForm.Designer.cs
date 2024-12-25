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
            txt_complainDescription.Location = new Point(78, 12);
            txt_complainDescription.Multiline = true;
            txt_complainDescription.Name = "txt_complainDescription";
            txt_complainDescription.Size = new Size(554, 249);
            txt_complainDescription.TabIndex = 0;
            // 
            // btn_submitComplain
            // 
            btn_submitComplain.Location = new Point(510, 286);
            btn_submitComplain.Name = "btn_submitComplain";
            btn_submitComplain.Size = new Size(122, 39);
            btn_submitComplain.TabIndex = 1;
            btn_submitComplain.Text = "Submit Complaint";
            btn_submitComplain.UseVisualStyleBackColor = true;
            btn_submitComplain.Click += btn_submitComplain_Click;
            // 
            // FileComplainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 450);
            Controls.Add(btn_submitComplain);
            Controls.Add(txt_complainDescription);
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