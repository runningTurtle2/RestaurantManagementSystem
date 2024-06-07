using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class LoginForm : Form
    {
        IMongoCollection<User> userCollection;
        public LoginForm()
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            userCollection = database.GetCollection<User>("users");
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;


            var filter = Builders<User>.Filter.Eq("Username", username) & 
                Builders<User>.Filter.Eq("Password", password);
            var users = userCollection.Find(filter).FirstOrDefault();

            if(users != null && users.Role == "staff")
            {
                // Take me to the menu
                MenuManagementForm menuManagementForm = new MenuManagementForm(users);
                menuManagementForm.Show();
                this.Hide();
            }
            else if(users != null && users.Role == "customer")
            {
                // Take me to the menu
                ReservationForm reservationForm = new ReservationForm(users.Id);
                reservationForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            // switch to register
            FormRegistration formRegistration = new FormRegistration();
            formRegistration.Show();
            this.Hide();
        }
    }
}
