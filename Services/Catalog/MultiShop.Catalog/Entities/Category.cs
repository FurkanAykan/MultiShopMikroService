using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MultiShop.Catalog.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // bu mongo db de primary key olduğunu belirler
        public string CategoryID { get; set; } // mongo db de string tututlur.
        public string CategoryName { get; set; }
    }
}
