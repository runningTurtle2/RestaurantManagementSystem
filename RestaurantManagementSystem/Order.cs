using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace RestaurantManagementSystem
{
    [BsonIgnoreExtraElements]
    [Serializable]
    public class Order
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("orderId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string OrderId { get; set; }

        [BsonElement("userId"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string UserId { get; set; }

        [BsonElement("items")]
        public List<string> Items { get; set; }

        [BsonElement("orderDate"), BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime Created { get; set; }

        [BsonElement("status"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Status { get; set; }
    }
}
