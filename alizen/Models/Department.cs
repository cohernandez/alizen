using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace alizen.Models
{
    public class Department
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string DepartmentId { get; set; }

        [RequiredAttribute(ErrorMessage="The field {0} is required")]
        [MaxLength(50, ErrorMessage="The field  {0} must be at least {1} characters length")]
        [BsonElement("Name Department")]
        public string Name { get; set; }

    }
}