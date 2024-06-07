namespace RestaurantManagementSystem
{
    partial class OrderProcessingForm
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
            this.btn_Order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_MenuItems = new System.Windows.Forms.DataGridView();
            this.labelItem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelStatus = new System.Windows.Forms.Label();
            this.dataGridView_OrderRealTimeStatus = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MenuItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderRealTimeStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Order
            // 
            this.btn_Order.Location = new System.Drawing.Point(268, 241);
            this.btn_Order.Name = "btn_Order";
            this.btn_Order.Size = new System.Drawing.Size(111, 41);
            this.btn_Order.TabIndex = 1;
            this.btn_Order.Text = "Place Order";
            this.btn_Order.UseVisualStyleBackColor = true;
            this.btn_Order.Click += new System.EventHandler(this.btn_Order_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 233);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Item:";
            // 
            // dataGridView_MenuItems
            // 
            this.dataGridView_MenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MenuItems.Location = new System.Drawing.Point(12, 36);
            this.dataGridView_MenuItems.Name = "dataGridView_MenuItems";
            this.dataGridView_MenuItems.Size = new System.Drawing.Size(424, 158);
            this.dataGridView_MenuItems.TabIndex = 12;
            this.dataGridView_MenuItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_MenuItems_CellContentClick);
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Location = new System.Drawing.Point(156, 233);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(0, 13);
            this.labelItem.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Quantity:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(159, 267);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(38, 20);
            this.numericUpDown1.TabIndex = 15;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(388, 220);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 17;
            // 
            // dataGridView_OrderRealTimeStatus
            // 
            this.dataGridView_OrderRealTimeStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_OrderRealTimeStatus.Location = new System.Drawing.Point(12, 356);
            this.dataGridView_OrderRealTimeStatus.Name = "dataGridView_OrderRealTimeStatus";
            this.dataGridView_OrderRealTimeStatus.Size = new System.Drawing.Size(424, 158);
            this.dataGridView_OrderRealTimeStatus.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Menu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Order";
            // 
            // OrderProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 537);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_OrderRealTimeStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.dataGridView_MenuItems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Order);
            this.Name = "OrderProcessingForm";
            this.Text = "OrderProcessingForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MenuItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_OrderRealTimeStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_MenuItems;
        private System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.DataGridView dataGridView_OrderRealTimeStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}