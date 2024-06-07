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
    public partial class MenuManagementForm : Form
    {
        IMongoCollection<MenuItem> menuCollection;
        public MenuManagementForm()
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            menuCollection = database.GetCollection<MenuItem>("menuItems");

            RefreshData();
        }
        public MenuManagementForm(User user)
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            menuCollection = database.GetCollection<MenuItem>("menuItems");

            User user1 = user;

            RefreshData();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string description = textBox_Description.Text;
            decimal price = 0.00M;
            string category = "";
            
            if(Decimal.TryParse(textBox_Price.Text, out price))
            {
                price = decimal.Parse(textBox_Price.Text);
            }
            // get radio string
            category = radioBtn();
            
            MenuItem menuItem = new MenuItem();
            menuItem.Name = name;
            menuItem.Description = description;
            menuItem.Price = price;
            menuItem.Category = category;

            menuCollection.InsertOne(menuItem);

            RefreshData();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string description = textBox_Description.Text;
            decimal price = 0.00M;
            string category = "";

            if (Decimal.TryParse(textBox_Price.Text, out price))
            {
                price = decimal.Parse(textBox_Price.Text);
            }
            // get radio string
            category = radioBtn();

            // updating
            var filterDefinition = Builders<MenuItem>.Filter.Eq("Name", name);
            var updateDefinition = Builders<MenuItem>.Update
                .Set("Description", description)
                .Set("Price", price)
                .Set("Category", category);

            menuCollection.UpdateOne(filterDefinition, updateDefinition);

            RefreshData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<MenuItem>.Filter.Eq("Name", textBox_Name.Text);
            menuCollection.DeleteOne(filterDefinition);

            RefreshData();
        }

        private void RefreshData()
        {
            // Filter.Empty pulls all data
            var filterDefinition = Builders<MenuItem>.Filter.Empty;
            var menuItems = menuCollection.Find(filterDefinition).ToList();

            dataGridView1.DataSource = menuItems;

            // clear all textboxes
            textBox_Name.Text = "";
            textBox_Description.Text = "";
            textBox_Price.Text = "";
        }
        
        private string radioBtn()
        {
            string s = "";

            if (radioBtn_Appetizer.Checked)
            {
                s = radioBtn_Appetizer.Text;
            }
            else if (radioBtn_MainCourse.Checked)
            {
                s = radioBtn_MainCourse.Text;
            }
            else if (radioBtn_Dessert.Checked)
            {
                s = radioBtn_Dessert.Text;
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }

            return s;
        }
    }
}
