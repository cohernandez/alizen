using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using System.ComponentModel.DataAnnotations;

namespace alizen.Models
{
    public class Sport
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }

        [BsonElement("Title")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }
        public string Instructor { get; set; }
        public string Image { get; set; }        
    }

    public class Nutrition{
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }
        
        [BsonElement("Title")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Level { get; set; }
        public string Instructor { get; set; }
        public string Image { get; set; }  
    }

}