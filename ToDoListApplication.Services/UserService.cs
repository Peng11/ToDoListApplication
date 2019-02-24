using System.Threading.Tasks;
using ToDoListApplication.Data;
using ToDoListApplication.Data.Repositories;

namespace ToDoListApplication.Services
{
    public interface IUserService
    {
        Task<UserEntity> UserLogIn(string userName, string password);
    }

    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserEntity> UserLogIn(string userName, string password)
        {
            return await _userRepository.GetUserAsync(userName, password);
        }
    }
}
