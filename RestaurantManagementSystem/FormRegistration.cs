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
using MongoDB.Bson;
using MongoDB.Driver;

namespace RestaurantManagementSystem
{
    public partial class FormRegistration : Form
    {
        IMongoCollection<User> userCollection;
        public FormRegistration()
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            userCollection = database.GetCollection<User>("users");
        }


        private void btn_Register_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            string email = textBoxEmail.Text;
            string role = "";
            var newUser = new User();

            if (radioBtn_Staff.Checked)
            {
                role = radioBtn_Staff.Text;
            }
            else if (radioBtn_Customer.Checked)
            {
                role = radioBtn_Customer.Text;
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

            var filter = Builders<User>.Filter.Eq("Username", username);
            var existingUser = userCollection.Find(filter).FirstOrDefault();
            if (existingUser == null)
            {
                var user = new User();
                user.UserId = "";
                user.Username = username;
                user.Password = password;
                user.Email = email;
                user.Role = role;

                userCollection.InsertOne(user);
                MessageBox.Show("Registration Processing", user.Username);
               
                user.UserId = user.Id;
                var filterDefinition = Builders<User>.Filter.Eq("Id", user.UserId);
                var update = Builders<User>.Update.Set("UserId", user.UserId);

                userCollection.UpdateOne(filterDefinition, update);
                MessageBox.Show("Registration Complete!", user.Username);
            }
            else
            {
                MessageBox.Show("Username already exist");
            }
            

        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Switch to Login
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

    }
}
