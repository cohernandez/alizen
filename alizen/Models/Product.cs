using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using System.ComponentModel.DataAnnotations;

namespace alizen.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        public string Name { get; set; }
        public decimal Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        // public DateTime LastBuy { get; set; }
    }
}