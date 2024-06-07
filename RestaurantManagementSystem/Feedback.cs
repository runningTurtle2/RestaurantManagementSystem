using System;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    [Serializable]
    public class Feedback
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("feedbackId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string FeedbackId { get; set; }

        [BsonElement("userId"), BsonRepresentation(MongoDB.Bson.BsonType.String)] 
        public string UserId { get; set;}

        [BsonElement("orderId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string OrderId { get; set; }

        [BsonElement("rating"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int Rating { get; set;}

        [BsonElement("comment"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Comment { get; set; }
    }
}
