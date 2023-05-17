using BearHunt.WedNight.Model;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BearHunt.WedNight.Entity
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private readonly ILogger<UserService> _logger;
        private readonly IMongoCollection<User> _collection;

        public UserRepository(ILogger<UserService> logger, IOptions<EntityConfigSection> options) : base(options)
        {
            _logger = logger;
            var mongoDatabase = Client.GetDatabase(options.Value.DatabaseName);
            _collection = mongoDatabase.GetCollection<User>("User");
        }

        public Task<List<User>> GetListAsync(UserFilter filter, ResultPaging paging)
        {
            const string func = "GetList";
            try
            {
                return _collection.Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "{func}: Exception caught.", func);
                throw;
            }
        }

        public bool DeleteData(string userId)
        {
            throw new NotImplementedException();
        }

        public User GetData(string userId)
        {
            throw new NotImplementedException();
        }

        public User SaveData(User user)
        {
            throw new NotImplementedException();
        }
    }
}
