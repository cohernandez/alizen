using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
// using System;

namespace alizen.Models
{
    // Recupera datos de Profesores
    public class Blog
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Description")]
        public string Description { get; set; }

        public string Instructor { get; set; }
    }
}