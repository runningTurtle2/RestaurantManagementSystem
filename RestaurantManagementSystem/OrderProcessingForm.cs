using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Configuration;
using static System.Windows.Forms.Menu;

namespace RestaurantManagementSystem
{
    public partial class OrderProcessingForm : Form
    {
        IMongoCollection<Order> orderCollection;
        IMongoCollection<MenuItem> menuItemCollection;
        public OrderProcessingForm()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            orderCollection = database.GetCollection<Order>("orders");


            //Menu Items
             menuItemCollection = database.GetCollection<MenuItem>("menuItems");


            RefreshData();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            // store the order details in the Orders collection
            // load properties
            int quantity = (int)numericUpDown1.Value; // obtain quantity
            string item = labelItem.Text;


            if (item != null)
            {
                MessageBox.Show($"{quantity} {item}", "Order");

                // save order
                Order order = new Order
                {

                };
            }
            else
            {
                MessageBox.Show("Something is wrong");
            }

            RefreshData();
        }

        private void RefreshData()
        {
            var filterDefinition = Builders<MenuItem>.Filter.Empty;

            var menuItems = menuItemCollection.Find(filterDefinition).ToList();
            dataGridView_MenuItems.DataSource = menuItems;

            var filterDefinition2 = Builders<Order>.Filter.Empty;

            var order = orderCollection.Find(filterDefinition2).ToList();
            dataGridView_OrderRealTimeStatus.DataSource = order;
        }

        private void dataGridView_MenuItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView_MenuItems.Rows[rowIndex];

            labelItem.Text = row.Cells[1].Value.ToString();
        }
    }
}
