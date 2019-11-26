using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace alizen.Models
{
    public class User 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        public string TitlePost { get; set; }

        public decimal Description { get; set; }

        public string Image { get; set; }

        public string Instructor { get; set; }
    }
}