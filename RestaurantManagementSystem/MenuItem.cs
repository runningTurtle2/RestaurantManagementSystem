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
    public class MenuItem
    {
        [BsonId, BsonElement("_id"), BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        // id
        public string ItemId { get; set; }

        [BsonElement("name"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Name { get; set; }

        [BsonElement("description"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Description { get; set; }

        [BsonElement("price"), BsonRepresentation(MongoDB.Bson.BsonType.Decimal128)]
        public decimal Price { get; set; }

        [BsonElement("category"), BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public string Category { get; set; }

    }
}
