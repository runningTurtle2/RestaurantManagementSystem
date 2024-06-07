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
    public partial class ReservationForm : Form
    {
        IMongoCollection<Reservation> reservationsCollection;
        string userId = "";
        string reservationId = string.Empty;
        public ReservationForm()
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            reservationsCollection = database.GetCollection<Reservation>("reservations");

        }
        // With user's Id
        public ReservationForm(string id)
        {
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            reservationsCollection = database.GetCollection<Reservation>("reservations");
            userId = id;
        }

        private void button_Reserve_Click(object sender, EventArgs e)
        {
            int tableNumber = (int)numericUpDown_TableNumber.Value;
            int numberOfPeople = (int)numericUpDown_NumberOfPeople.Value;
            DateTime dateTime = dateTimePicker_Date.Value;

            Reservation reservation = new Reservation
            {
                TableNumber = tableNumber,
                NumberOfPeople = numberOfPeople,
                ReservationDate = dateTime,
                ReservationId = "",
                UserId = userId
            };
            //Console.WriteLine(userId);
            reservationsCollection.InsertOne(reservation);

            // save ResercationId
            reservation.ReservationId = reservation.Id;
            //This is for cancel function without userId
            reservationId = reservation.ReservationId;

            var filterDefinition = Builders<Reservation>.Filter.Eq("Id", reservation.ReservationId);
            var update = Builders<Reservation>.Update.Set("ReservationId", reservation.ReservationId);

            reservationsCollection.UpdateOne(filterDefinition, update);
            DialogResult dr = MessageBox.Show("Reservation Completed.\nDo you want to continue to the menu?", "Reservation Message", MessageBoxButtons.YesNo);
            switch (dr)
            {
                 case DialogResult.Yes:
                    OrderProcessingForm orderProcessingForm = new OrderProcessingForm();
                    orderProcessingForm.Show();
                    this.Hide();
                    break;

                 case DialogResult.No:
                    break;

            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            // deletes collection if user is logged in
            if(userId != "")
            {
                var filterDefinition = Builders<Reservation>.Filter.Eq("UserId", userId);
                reservationsCollection.DeleteOne(filterDefinition);
            }
            else
            {

                var filterDefinition = Builders<Reservation>.Filter.Eq("ReservationId", reservationId);
                reservationsCollection.DeleteOne(filterDefinition);
            }


            MessageBox.Show("Reservation Canceled");
        }
    }
}
