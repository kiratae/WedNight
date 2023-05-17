using Microsoft.Extensions.Options;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;

namespace BearHunt.WedNight.Entity
{
    public class BaseRepository
    {
        private static MongoClient _mongoClient = null;

        public BaseRepository(IOptions<EntityConfigSection> options)
        {
            if (_mongoClient == null)
            {
                string connectionString = options.Value.ConnectionString;
                connectionString = connectionString.Replace("<password>", options.Value.Password);
                _mongoClient = new MongoClient(connectionString);
            }
        }

        protected static MongoClient Client => _mongoClient;
    }
}
