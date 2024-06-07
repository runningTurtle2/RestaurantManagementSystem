namespace RestaurantManagementSystem
{
    partial class FeedbackForm
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
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.numericUpDown_Rating = new System.Windows.Forms.NumericUpDown();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rating)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(80, 37);
            this.textBox_Comment.MaxLength = 150;
            this.textBox_Comment.Multiline = true;
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(177, 93);
            this.textBox_Comment.TabIndex = 0;
            // 
            // numericUpDown_Rating
            // 
            this.numericUpDown_Rating.Location = new System.Drawing.Point(80, 149);
            this.numericUpDown_Rating.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown_Rating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_Rating.Name = "numericUpDown_Rating";
            this.numericUpDown_Rating.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown_Rating.TabIndex = 1;
            this.numericUpDown_Rating.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(80, 184);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 2;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rating";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(178, 189);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(0, 13);
            this.label_Status.TabIndex = 5;
            // 
            // FeedbackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 232);
            this.Controls.Add(this.label_Status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.numericUpDown_Rating);
            this.Controls.Add(this.textBox_Comment);
            this.Name = "FeedbackForm";
            this.Text = "FeedbackForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.NumericUpDown numericUpDown_Rating;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Status;
    }
}