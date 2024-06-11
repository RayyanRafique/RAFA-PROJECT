using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
namespace RAFA_PROJECT
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("First Name")]
        public string fName { get; set; }

        [BsonElement("Last Name")]
        public string lName { get; set; }

        [BsonElement("Email")]
        public string Email { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("medicines")]
        public List<Medicine> Medicines { get; set; }

        public User()
        {
            Medicines = new List<Medicine>();
        }
    }

}