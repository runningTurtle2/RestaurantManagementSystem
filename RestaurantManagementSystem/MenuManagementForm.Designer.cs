namespace RestaurantManagementSystem
{
    partial class MenuManagementForm
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Description = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioBtn_Appetizer = new System.Windows.Forms.RadioButton();
            this.radioBtn_MainCourse = new System.Windows.Forms.RadioButton();
            this.radioBtn_Dessert = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(428, 77);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(428, 134);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(428, 199);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 222);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(184, 64);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(203, 20);
            this.textBox_Name.TabIndex = 4;
            // 
            // textBox_Description
            // 
            this.textBox_Description.Location = new System.Drawing.Point(184, 114);
            this.textBox_Description.Multiline = true;
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.Size = new System.Drawing.Size(203, 66);
            this.textBox_Description.TabIndex = 5;
            // 
            // textBox_Price
            // 
            this.textBox_Price.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_Price.Location = new System.Drawing.Point(184, 199);
            this.textBox_Price.MaxLength = 10;
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.Size = new System.Drawing.Size(118, 20);
            this.textBox_Price.TabIndex = 6;
            this.textBox_Price.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Category";
            // 
            // radioBtn_Appetizer
            // 
            this.radioBtn_Appetizer.AutoSize = true;
            this.radioBtn_Appetizer.Checked = true;
            this.radioBtn_Appetizer.Location = new System.Drawing.Point(184, 244);
            this.radioBtn_Appetizer.Name = "radioBtn_Appetizer";
            this.radioBtn_Appetizer.Size = new System.Drawing.Size(69, 17);
            this.radioBtn_Appetizer.TabIndex = 12;
            this.radioBtn_Appetizer.TabStop = true;
            this.radioBtn_Appetizer.Text = "Appetizer";
            this.radioBtn_Appetizer.UseVisualStyleBackColor = true;
            // 
            // radioBtn_MainCourse
            // 
            this.radioBtn_MainCourse.AutoSize = true;
            this.radioBtn_MainCourse.Location = new System.Drawing.Point(259, 244);
            this.radioBtn_MainCourse.Name = "radioBtn_MainCourse";
            this.radioBtn_MainCourse.Size = new System.Drawing.Size(84, 17);
            this.radioBtn_MainCourse.TabIndex = 13;
            this.radioBtn_MainCourse.TabStop = true;
            this.radioBtn_MainCourse.Text = "Main Course";
            this.radioBtn_MainCourse.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Dessert
            // 
            this.radioBtn_Dessert.AutoSize = true;
            this.radioBtn_Dessert.Location = new System.Drawing.Point(349, 244);
            this.radioBtn_Dessert.Name = "radioBtn_Dessert";
            this.radioBtn_Dessert.Size = new System.Drawing.Size(61, 17);
            this.radioBtn_Dessert.TabIndex = 14;
            this.radioBtn_Dessert.TabStop = true;
            this.radioBtn_Dessert.Text = "Dessert";
            this.radioBtn_Dessert.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(524, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Enter name to update";
            // 
            // MenuManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 579);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioBtn_Dessert);
            this.Controls.Add(this.radioBtn_MainCourse);
            this.Controls.Add(this.radioBtn_Appetizer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_Description);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Name = "MenuManagementForm";
            this.Text = "MenuManagementForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Description;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioBtn_Appetizer;
        private System.Windows.Forms.RadioButton radioBtn_MainCourse;
        private System.Windows.Forms.RadioButton radioBtn_Dessert;
        private System.Windows.Forms.Label label5;
    }
}