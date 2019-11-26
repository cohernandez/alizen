using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
// using System;

namespace alizen.Models
{
    /*
    Lista de tareas
    1- Recupera datos de los instructores
    2- Solo los instructores pueden redactar post
    3- Los usuarios pueden botar, seguir post, comentar post
    */ 
    public class Blog
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Description")]
        public string Post { get; set; }

        public string Instructor { get; set; }
    }
}