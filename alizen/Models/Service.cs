using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using System.ComponentModel.DataAnnotations;

namespace alizen.Models
{
    public class Service : Course
    {
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        //public string _Id { get; set; }

        [BsonElement("Title")]
        // aca deberia ir una lista de niveles
        public string Level { get; set; }
        public string Contract {get; set;}
        public String Planning {get;set;}
    }

}