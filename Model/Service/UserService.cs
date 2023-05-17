using Microsoft.Extensions.Logging;

namespace BearHunt.WedNight.Model
{
    public class UserService : BaseService, IUserService
    {
        private readonly ILogger<UserService> _logger;
        private static IUserRepository _repository;

        public UserService(ILogger<UserService> logger, IUserRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        public virtual Task<List<User>> GetListAsync(UserFilter filter, ResultPaging paging)
        {
            const string func = "GetList";
            try
            {
                return _repository.GetListAsync(filter, paging);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "{func}: Exception caught.", func);
                throw;
            }
        }

        public User GetData(string userId)
        {
            const string func = "GetData";
            try
            {
                return _repository.GetData(userId);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "{func}: Exception caught with user id '{userId}'", func, userId);
                throw;
            }
        }

        public User SaveData(User user)
        {
            const string func = "SaveData";
            try
            {
                return _repository.SaveData(user);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "{func}: Exception caught.", func);
                throw;
            }
        }

        public bool DeleteData(string userId)
        {
            const string func = "DeleteData";
            try
            {
                return _repository.DeleteData(userId);
            }
            catch (Exception ex)
            {
                _logger.LogInformation(ex, "{func}: Exception caught with user id '{userId}'", func, userId);
                throw;
            }
        }
    }
}
