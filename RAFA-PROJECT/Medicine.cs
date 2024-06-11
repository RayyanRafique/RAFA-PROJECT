using MongoDB.Bson.Serialization.Attributes;
using System;

namespace RAFA_PROJECT
{
    public class Medicine
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("dosage")]
        public string Dosage { get; set; }

        [BsonElement("intake")]
        public string Intake { get; set; }

        [BsonElement("quantity")]
        public int Quantity { get; set; }

        [BsonElement("specialInstructions")]
        public string SpecialInstructions { get; set; }

        [BsonElement("timeToTake")]
        public DateTime TimeToTake { get; set; }
    }
}