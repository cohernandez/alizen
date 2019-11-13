using System;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace alizen.Models
{
    // Recupera datos del Catalogo
    public class Catalogue
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        // Codigo Categoria
        public string Id { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        public string CodCategoria { get; set; }
    }
}
