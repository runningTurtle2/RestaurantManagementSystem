using System;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagementSystem
{
    [BsonIgnoreExtraElements]
    [Serializable]
    public class Reservation
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("reservationId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string ReservationId { get; set; }

        [BsonElement("userId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string UserId { get; set; }

        [BsonElement("tableNumber"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int TableNumber { get; set; }

        [BsonElement("reservationDate"), BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime ReservationDate { get; set; }

        [BsonElement("numberOfPeople"), BsonRepresentation(MongoDB.Bson.BsonType.Int32)]
        public int NumberOfPeople { get; set; }
    }
}
