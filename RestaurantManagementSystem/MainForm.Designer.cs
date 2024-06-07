namespace RestaurantManagementSystem
{
    partial class MainForm
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_MenuManagement = new System.Windows.Forms.Button();
            this.btn_OrderProcessing = new System.Windows.Forms.Button();
            this.btn_Reservations = new System.Windows.Forms.Button();
            this.btn_Feedback = new System.Windows.Forms.Button();
            this.btn_OrderTracking = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(29, 68);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(109, 23);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.Location = new System.Drawing.Point(184, 68);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(104, 23);
            this.btn_Register.TabIndex = 1;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_MenuManagement
            // 
            this.btn_MenuManagement.Location = new System.Drawing.Point(29, 113);
            this.btn_MenuManagement.Name = "btn_MenuManagement";
            this.btn_MenuManagement.Size = new System.Drawing.Size(109, 23);
            this.btn_MenuManagement.TabIndex = 2;
            this.btn_MenuManagement.Text = "Menu Management";
            this.btn_MenuManagement.UseVisualStyleBackColor = true;
            this.btn_MenuManagement.Click += new System.EventHandler(this.btn_MenuManagement_Click);
            // 
            // btn_OrderProcessing
            // 
            this.btn_OrderProcessing.Location = new System.Drawing.Point(184, 113);
            this.btn_OrderProcessing.Name = "btn_OrderProcessing";
            this.btn_OrderProcessing.Size = new System.Drawing.Size(104, 23);
            this.btn_OrderProcessing.TabIndex = 3;
            this.btn_OrderProcessing.Text = "Order Processing";
            this.btn_OrderProcessing.UseVisualStyleBackColor = true;
            this.btn_OrderProcessing.Click += new System.EventHandler(this.btn_OrderProcessing_Click);
            // 
            // btn_Reservations
            // 
            this.btn_Reservations.Location = new System.Drawing.Point(29, 161);
            this.btn_Reservations.Name = "btn_Reservations";
            this.btn_Reservations.Size = new System.Drawing.Size(109, 23);
            this.btn_Reservations.TabIndex = 4;
            this.btn_Reservations.Text = "Reservations";
            this.btn_Reservations.UseVisualStyleBackColor = true;
            this.btn_Reservations.Click += new System.EventHandler(this.btn_Reservations_Click);
            // 
            // btn_Feedback
            // 
            this.btn_Feedback.Location = new System.Drawing.Point(184, 161);
            this.btn_Feedback.Name = "btn_Feedback";
            this.btn_Feedback.Size = new System.Drawing.Size(104, 23);
            this.btn_Feedback.TabIndex = 5;
            this.btn_Feedback.Text = "Feedback";
            this.btn_Feedback.UseVisualStyleBackColor = true;
            this.btn_Feedback.Click += new System.EventHandler(this.btn_Feedback_Click);
            // 
            // btn_OrderTracking
            // 
            this.btn_OrderTracking.Location = new System.Drawing.Point(29, 213);
            this.btn_OrderTracking.Name = "btn_OrderTracking";
            this.btn_OrderTracking.Size = new System.Drawing.Size(109, 23);
            this.btn_OrderTracking.TabIndex = 6;
            this.btn_OrderTracking.Text = "Order Tracking";
            this.btn_OrderTracking.UseVisualStyleBackColor = true;
            this.btn_OrderTracking.Click += new System.EventHandler(this.btn_OrderTracking_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 269);
            this.Controls.Add(this.btn_OrderTracking);
            this.Controls.Add(this.btn_Feedback);
            this.Controls.Add(this.btn_Reservations);
            this.Controls.Add(this.btn_OrderProcessing);
            this.Controls.Add(this.btn_MenuManagement);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_MenuManagement;
        private System.Windows.Forms.Button btn_OrderProcessing;
        private System.Windows.Forms.Button btn_Reservations;
        private System.Windows.Forms.Button btn_Feedback;
        private System.Windows.Forms.Button btn_OrderTracking;
    }
}