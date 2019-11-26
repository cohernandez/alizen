using System;
using System.Collections.Generic;
using System.Text;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace alizen.Models
{
    public class Instructor : User
    {

        // public Basket Basket { get;set;}
        /*
        1- Pueden organizar y vender sus clases dentro de las instalaciones de Alizen
        2- Pueden usar la plataforma para gestionar sus clientes
        3- Deben entregar el servicio con los clientes inscritos   
        4- Indicar el maximo de clientes por clase 
         */
        
        //[BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        // public string Id { get; set; }

        [BsonElement("Instructor")]
        public string HorarioTrabajo { get; set; }
        public decimal ValorHora { get; set; }
        // deberia ser una lista correspondiente a las especialidades de alizen
        public string Specialty { get; set; }
        //public Instructor Instructor { get; set; }
    }
}