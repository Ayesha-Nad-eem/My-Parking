namespace My_Parking
{
    partial class AddParkingForm
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
            lbl_latitude = new Label();
            lbl_longitude = new Label();
            lbl_slots = new Label();
            lbl_price = new Label();
            txt_latitude = new TextBox();
            txt_longitude = new TextBox();
            txt_slots = new TextBox();
            txt_price = new TextBox();
            btn_add = new Button();
            btn_clear = new Button();
            txt_locationName = new TextBox();
            lbl_locationName = new Label();
            SuspendLayout();
            // 
            // lbl_latitude
            // 
            lbl_latitude.AutoSize = true;
            lbl_latitude.Location = new Point(102, 141);
            lbl_latitude.Margin = new Padding(7, 0, 7, 0);
            lbl_latitude.Name = "lbl_latitude";
            lbl_latitude.Size = new Size(105, 31);
            lbl_latitude.TabIndex = 1;
            lbl_latitude.Text = "Latitude";
            // 
            // lbl_longitude
            // 
            lbl_longitude.AutoSize = true;
            lbl_longitude.Location = new Point(102, 223);
            lbl_longitude.Margin = new Padding(7, 0, 7, 0);
            lbl_longitude.Name = "lbl_longitude";
            lbl_longitude.Size = new Size(125, 31);
            lbl_longitude.TabIndex = 2;
            lbl_longitude.Text = "Longitude";
            // 
            // lbl_slots
            // 
            lbl_slots.AutoSize = true;
            lbl_slots.Location = new Point(100, 387);
            lbl_slots.Margin = new Padding(7, 0, 7, 0);
            lbl_slots.Name = "lbl_slots";
            lbl_slots.Size = new Size(145, 31);
            lbl_slots.TabIndex = 3;
            lbl_slots.Text = "No. of Slots";
            // 
            // lbl_price
            // 
            lbl_price.AutoSize = true;
            lbl_price.Location = new Point(100, 469);
            lbl_price.Margin = new Padding(7, 0, 7, 0);
            lbl_price.Name = "lbl_price";
            lbl_price.Size = new Size(158, 31);
            lbl_price.TabIndex = 4;
            lbl_price.Text = "Price per slot";
            // 
            // txt_latitude
            // 
            txt_latitude.Location = new Point(102, 178);
            txt_latitude.Margin = new Padding(7, 6, 7, 6);
            txt_latitude.Name = "txt_latitude";
            txt_latitude.Size = new Size(1187, 39);
            txt_latitude.TabIndex = 6;
            txt_latitude.TextChanged += txt_latitude_TextChanged;
            // 
            // txt_longitude
            // 
            txt_longitude.Location = new Point(102, 260);
            txt_longitude.Margin = new Padding(7, 6, 7, 6);
            txt_longitude.Name = "txt_longitude";
            txt_longitude.Size = new Size(1187, 39);
            txt_longitude.TabIndex = 7;
            // 
            // txt_slots
            // 
            txt_slots.Location = new Point(100, 424);
            txt_slots.Margin = new Padding(7, 6, 7, 6);
            txt_slots.Name = "txt_slots";
            txt_slots.Size = new Size(1187, 39);
            txt_slots.TabIndex = 8;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(102, 506);
            txt_price.Margin = new Padding(7, 6, 7, 6);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(1187, 39);
            txt_price.TabIndex = 9;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Green;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.ForeColor = Color.White;
            btn_add.Location = new Point(102, 588);
            btn_add.Margin = new Padding(7, 6, 7, 6);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(1187, 47);
            btn_add.TabIndex = 10;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Gray;
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(100, 656);
            btn_clear.Margin = new Padding(7, 6, 7, 6);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(1187, 47);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // txt_locationName
            // 
            txt_locationName.Location = new Point(102, 342);
            txt_locationName.Margin = new Padding(7, 6, 7, 6);
            txt_locationName.Name = "txt_locationName";
            txt_locationName.Size = new Size(1187, 39);
            txt_locationName.TabIndex = 13;
            // 
            // lbl_locationName
            // 
            lbl_locationName.AutoSize = true;
            lbl_locationName.Location = new Point(102, 305);
            lbl_locationName.Margin = new Padding(7, 0, 7, 0);
            lbl_locationName.Name = "lbl_locationName";
            lbl_locationName.Size = new Size(181, 31);
            lbl_locationName.TabIndex = 12;
            lbl_locationName.Text = "Location Name";
            // 
            // AddParkingForm
            // 
            AutoScaleDimensions = new SizeF(15F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 852);
            Controls.Add(txt_locationName);
            Controls.Add(lbl_locationName);
            Controls.Add(btn_clear);
            Controls.Add(btn_add);
            Controls.Add(txt_price);
            Controls.Add(txt_slots);
            Controls.Add(txt_longitude);
            Controls.Add(txt_latitude);
            Controls.Add(lbl_price);
            Controls.Add(lbl_slots);
            Controls.Add(lbl_longitude);
            Controls.Add(lbl_latitude);
            Font = new Font("Times New Roman", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(7, 6, 7, 6);
            Name = "AddParkingForm";
            Text = "AddParkingForm";
            Load += AddParkingForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_latitude;
        private Label lbl_longitude;
        private Label lbl_slots;
        private Label lbl_price;
        private TextBox txt_latitude;
        private TextBox txt_longitude;
        private TextBox txt_slots;
        private TextBox txt_price;
        private Button btn_add;
        private Button btn_clear;
        private TextBox txt_locationName;
        private Label lbl_locationName;
    }
}