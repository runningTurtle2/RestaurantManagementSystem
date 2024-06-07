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
    public partial class FeedbackForm : Form
    {
        IMongoCollection<Feedback> feedbackCollection;
        public FeedbackForm()
        {// this is the feedback
            InitializeComponent();

            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            feedbackCollection = database.GetCollection<Feedback>("feedback");

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string comment = textBox_Comment.Text;
            int rating = (int)numericUpDown_Rating.Value;

            //commit to colletion

            Feedback feedback = new Feedback();
            feedback.FeedbackId = "";
            feedback.UserId = "";
            feedback.OrderId = "";
            feedback.Comment = comment;
            feedback.Rating = rating;

            feedbackCollection.InsertOne(feedback);

            // save feedbackID
            feedback.FeedbackId = feedback.Id;
            var filterDefinition = Builders<Feedback>.Filter.Eq("Id", feedback.FeedbackId);
            var update = Builders<Feedback>.Update.Set("FeedbackId", feedback.FeedbackId);

            feedbackCollection.UpdateOne(filterDefinition, update);

            label_Status.Text = "Submission Completed";
        }
    }
}
