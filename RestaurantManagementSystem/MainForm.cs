using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Take me to the Login
            LoginForm login = new LoginForm();
            login.Show();

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            // Take me to the registration
            FormRegistration form = new FormRegistration();
            form.Show();
        }

        private void btn_MenuManagement_Click(object sender, EventArgs e)
        {
            // Take me to the menuManagement
            MenuManagementForm menuManagementForm = new MenuManagementForm();
            menuManagementForm.Show();
        }

        private void btn_OrderProcessing_Click(object sender, EventArgs e)
        {
            // Take me to the Order Processing
            OrderProcessingForm orderProcessing = new OrderProcessingForm();
            orderProcessing.Show();
        }

        private void btn_Reservations_Click(object sender, EventArgs e)
        {
            // Take me to the Reservations
            ReservationForm reservation = new ReservationForm();
            reservation.Show();
        }

        private void btn_Feedback_Click(object sender, EventArgs e)
        {
            // Take me to the Feedback
            FeedbackForm feedback = new FeedbackForm();
            feedback.Show();
        }

        private void btn_OrderTracking_Click(object sender, EventArgs e)
        {
            // Take me to the OrderTracking
            OrderTrackingService orderTrackingService = new OrderTrackingService();
            orderTrackingService.Show();
        }
    }
}
