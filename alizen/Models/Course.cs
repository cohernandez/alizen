using System;
using System.Collections.Generic;
using System.Text;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace alizen.Models
{
    public class Course
    {
        /* Lista de Tareas
        1- Organizar y vender sus Cursos dentro de las instalaciones de Alizen
        2- Pueden usar la plataforma para gestionar los cursos con los clientes
        3- Deben entregar el servicio con los clientes inscritos   
        4- Indicar el maximo de clientes por curso 
        */
        // public Course Course { get;set;}
        
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Title")]
        public string Name { get; set; }
        public string Interest { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int MaxAlumnos {get; set;}
        public int CantidadClases {get; set;}
        // aca deberia hacer una lista de instructores
        public string Instructor { get; set; }
        public decimal Price { get; set; }
    }
}