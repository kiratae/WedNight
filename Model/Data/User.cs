using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BearHunt.WedNight.Model
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string UserId { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string DisplayName { get; set; }

        public int? ImageFileId { get; set; }

        public DateTime? LockDate { get; set; }

        public string LockIP { get; set; }

        public DateTime? LockDate2 { get; set; }

        public string LockIP2 { get; set; }

        public bool IsActive { get; set; }
    }
}
