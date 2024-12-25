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
            dataGridViewParkings.Location = new Point(120, 24);
            dataGridViewParkings.Margin = new Padding(7, 6, 7, 6);
            dataGridViewParkings.Name = "dataGridViewParkings";
            dataGridViewParkings.RowHeadersWidth = 82;
            dataGridViewParkings.RowTemplate.Height = 25;
            dataGridViewParkings.Size = new Size(1502, 684);
            dataGridViewParkings.TabIndex = 0;
            // 
            // btn_remove
            // 
            btn_remove.BackColor = Color.Maroon;
            btn_remove.FlatAppearance.BorderSize = 0;
            btn_remove.FlatStyle = FlatStyle.Flat;
            btn_remove.ForeColor = Color.White;
            btn_remove.Location = new Point(1052, 737);
            btn_remove.Margin = new Padding(7, 6, 7, 6);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new Size(207, 71);
            btn_remove.TabIndex = 1;
            btn_remove.Text = "Remove";
            btn_remove.UseVisualStyleBackColor = false;
            btn_remove.Click += btn_remove_Click;
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(457, 777);
            lbl_ID.Margin = new Padding(7, 0, 7, 0);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(41, 31);
            lbl_ID.TabIndex = 2;
            lbl_ID.Text = "ID";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(512, 769);
            txt_ID.Margin = new Padding(7, 6, 7, 6);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(429, 39);
            txt_ID.TabIndex = 3;
            // 
            // RemoveParkingForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1748, 910);
            Controls.Add(txt_ID);
            Controls.Add(lbl_ID);
            Controls.Add(btn_remove);
            Controls.Add(dataGridViewParkings);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 6, 7, 6);
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