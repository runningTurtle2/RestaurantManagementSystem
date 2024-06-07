namespace RestaurantManagementSystem
{
    partial class ReservationForm
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
            this.numericUpDown_TableNumber = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_NumberOfPeople = new System.Windows.Forms.NumericUpDown();
            this.label_TableNumber = new System.Windows.Forms.Label();
            this.label_NumberOfPeople = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Reserve = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TableNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_TableNumber
            // 
            this.numericUpDown_TableNumber.Location = new System.Drawing.Point(147, 72);
            this.numericUpDown_TableNumber.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_TableNumber.Name = "numericUpDown_TableNumber";
            this.numericUpDown_TableNumber.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_TableNumber.TabIndex = 0;
            this.numericUpDown_TableNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Location = new System.Drawing.Point(147, 174);
            this.dateTimePicker_Date.MaxDate = new System.DateTime(2110, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker_Date.MinDate = new System.DateTime(2024, 5, 25, 23, 59, 59, 0);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker_Date.TabIndex = 1;
            // 
            // numericUpDown_NumberOfPeople
            // 
            this.numericUpDown_NumberOfPeople.Location = new System.Drawing.Point(147, 120);
            this.numericUpDown_NumberOfPeople.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_NumberOfPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_NumberOfPeople.Name = "numericUpDown_NumberOfPeople";
            this.numericUpDown_NumberOfPeople.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown_NumberOfPeople.TabIndex = 2;
            this.numericUpDown_NumberOfPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_TableNumber
            // 
            this.label_TableNumber.AutoSize = true;
            this.label_TableNumber.Location = new System.Drawing.Point(38, 79);
            this.label_TableNumber.Name = "label_TableNumber";
            this.label_TableNumber.Size = new System.Drawing.Size(74, 13);
            this.label_TableNumber.TabIndex = 3;
            this.label_TableNumber.Text = "Table Number";
            // 
            // label_NumberOfPeople
            // 
            this.label_NumberOfPeople.AutoSize = true;
            this.label_NumberOfPeople.Location = new System.Drawing.Point(38, 127);
            this.label_NumberOfPeople.Name = "label_NumberOfPeople";
            this.label_NumberOfPeople.Size = new System.Drawing.Size(92, 13);
            this.label_NumberOfPeople.TabIndex = 4;
            this.label_NumberOfPeople.Text = "Number of People";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reservation Date";
            // 
            // button_Reserve
            // 
            this.button_Reserve.Location = new System.Drawing.Point(107, 222);
            this.button_Reserve.Name = "button_Reserve";
            this.button_Reserve.Size = new System.Drawing.Size(128, 23);
            this.button_Reserve.TabIndex = 6;
            this.button_Reserve.Text = "Reserve";
            this.button_Reserve.UseVisualStyleBackColor = true;
            this.button_Reserve.Click += new System.EventHandler(this.button_Reserve_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(196, 307);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel Reservations";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Do you want to cancel?";
            // 
            // ReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 374);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Reserve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_NumberOfPeople);
            this.Controls.Add(this.label_TableNumber);
            this.Controls.Add(this.numericUpDown_NumberOfPeople);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.numericUpDown_TableNumber);
            this.Name = "ReservationForm";
            this.Text = "ReservationForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_TableNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_NumberOfPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_TableNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.NumericUpDown numericUpDown_NumberOfPeople;
        private System.Windows.Forms.Label label_TableNumber;
        private System.Windows.Forms.Label label_NumberOfPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Reserve;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label1;
    }
}