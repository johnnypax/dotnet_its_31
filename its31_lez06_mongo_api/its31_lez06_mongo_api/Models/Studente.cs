using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace its31_lez06_mongo_api.Models
{
    public class Studente
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string? Nominativo { get; set; }
        public string? Matricola { get; set; }
        public Corso? Corso { get; set; }
    }
}
