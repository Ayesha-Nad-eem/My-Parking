namespace My_Parking
{
    partial class EditParkingForm
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
            txt_locationName = new TextBox();
            lbl_locationName = new Label();
            btn_clear = new Button();
            btn_saveEdit = new Button();
            txt_price = new TextBox();
            txt_slots = new TextBox();
            txt_longitude = new TextBox();
            txt_latitude = new TextBox();
            txt_ID = new TextBox();
            lbl_price = new Label();
            lbl_slots = new Label();
            lbl_longitude = new Label();
            lbl_latitude = new Label();
            lbl_ID = new Label();
            SuspendLayout();
            // 
            // txt_locationName
            // 
            txt_locationName.Location = new Point(52, 393);
            txt_locationName.Margin = new Padding(7, 6, 7, 6);
            txt_locationName.Name = "txt_locationName";
            txt_locationName.Size = new Size(1431, 39);
            txt_locationName.TabIndex = 27;
            // 
            // lbl_locationName
            // 
            lbl_locationName.AutoSize = true;
            lbl_locationName.Location = new Point(52, 356);
            lbl_locationName.Margin = new Padding(7, 0, 7, 0);
            lbl_locationName.Name = "lbl_locationName";
            lbl_locationName.Size = new Size(181, 31);
            lbl_locationName.TabIndex = 26;
            lbl_locationName.Text = "Location Name";
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Gray;
            btn_clear.FlatAppearance.BorderSize = 0;
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(52, 715);
            btn_clear.Margin = new Padding(7, 6, 7, 6);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(1431, 56);
            btn_clear.TabIndex = 25;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_saveEdit
            // 
            btn_saveEdit.BackColor = Color.Green;
            btn_saveEdit.FlatAppearance.BorderSize = 0;
            btn_saveEdit.FlatStyle = FlatStyle.Flat;
            btn_saveEdit.ForeColor = Color.White;
            btn_saveEdit.Location = new Point(52, 647);
            btn_saveEdit.Margin = new Padding(7, 6, 7, 6);
            btn_saveEdit.Name = "btn_saveEdit";
            btn_saveEdit.Size = new Size(1431, 56);
            btn_saveEdit.TabIndex = 24;
            btn_saveEdit.Text = "Save Edit";
            btn_saveEdit.UseVisualStyleBackColor = false;
            btn_saveEdit.Click += btn_saveEdit_Click;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(52, 554);
            txt_price.Margin = new Padding(7, 6, 7, 6);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(1431, 39);
            txt_price.TabIndex = 23;
            // 
            // txt_slots
            // 
            txt_slots.Location = new Point(52, 473);
            txt_slots.Margin = new Padding(7, 6, 7, 6);
            txt_slots.Name = "txt_slots";
            txt_slots.Size = new Size(1431, 39);
            txt_slots.TabIndex = 22;
            // 
            // txt_longitude
            // 
            txt_longitude.Location = new Point(52, 313);
            txt_longitude.Margin = new Padding(7, 6, 7, 6);
            txt_longitude.Name = "txt_longitude";
            txt_longitude.Size = new Size(1431, 39);
            txt_longitude.TabIndex = 21;
            // 
            // txt_latitude
            // 
            txt_latitude.Location = new Point(52, 232);
            txt_latitude.Margin = new Padding(7, 6, 7, 6);
            txt_latitude.Name = "txt_latitude";
            txt_latitude.Size = new Size(1431, 39);
            txt_latitude.TabIndex = 20;
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(52, 152);
            txt_ID.Margin = new Padding(7, 6, 7, 6);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(1431, 39);
            txt_ID.TabIndex = 19;
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Location = new Point(52, 517);
            lbl_price.Margin = new Padding(7, 0, 7, 0);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(158, 31);
            lbl_price.TabIndex = 18;
            lbl_price.Text = "Price per slot";
            // 
            // lbl_slots
            // 
            lbl_slots.AutoSize = true;
            lbl_slots.Location = new Point(52, 437);
            lbl_slots.Margin = new Padding(7, 0, 7, 0);
            lbl_slots.Name = "lbl_slots";
            lbl_slots.Size = new Size(145, 31);
            lbl_slots.TabIndex = 17;
            lbl_slots.Text = "No. of Slots";
            // 
            // lbl_longitude
            // 
            lbl_longitude.AutoSize = true;
            lbl_longitude.Location = new Point(52, 276);
            lbl_longitude.Margin = new Padding(7, 0, 7, 0);
            lbl_longitude.Name = "lbl_longitude";
            lbl_longitude.Size = new Size(125, 31);
            lbl_longitude.TabIndex = 16;
            lbl_longitude.Text = "Longitude";
            // 
            // lbl_latitude
            // 
            lbl_latitude.AutoSize = true;
            lbl_latitude.Location = new Point(52, 196);
            lbl_latitude.Margin = new Padding(7, 0, 7, 0);
            lbl_latitude.Name = "lbl_latitude";
            lbl_latitude.Size = new Size(105, 31);
            lbl_latitude.TabIndex = 15;
            lbl_latitude.Text = "Latitude";
            // 
            // lbl_ID
            // 
            lbl_ID.AutoSize = true;
            lbl_ID.Location = new Point(52, 115);
            lbl_ID.Margin = new Padding(7, 0, 7, 0);
            lbl_ID.Name = "lbl_ID";
            lbl_ID.Size = new Size(41, 31);
            lbl_ID.TabIndex = 14;
            lbl_ID.Text = "ID";
            // 
            // EditParkingForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 923);
            Controls.Add(txt_locationName);
            Controls.Add(lbl_locationName);
            Controls.Add(btn_clear);
            Controls.Add(btn_saveEdit);
            Controls.Add(txt_price);
            Controls.Add(txt_slots);
            Controls.Add(txt_longitude);
            Controls.Add(txt_latitude);
            Controls.Add(txt_ID);
            Controls.Add(lbl_price);
            Controls.Add(lbl_slots);
            Controls.Add(lbl_longitude);
            Controls.Add(lbl_latitude);
            Controls.Add(lbl_ID);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "EditParkingForm";
            Text = "EditParkingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_locationName;
        private Label lbl_locationName;
        private Button btn_clear;
        private Button btn_saveEdit;
        private TextBox txt_price;
        private TextBox txt_slots;
        private TextBox txt_longitude;
        private TextBox txt_latitude;
        private TextBox txt_ID;
        private Label lbl_price;
        private Label lbl_slots;
        private Label lbl_longitude;
        private Label lbl_latitude;
        private Label lbl_ID;
    }
}