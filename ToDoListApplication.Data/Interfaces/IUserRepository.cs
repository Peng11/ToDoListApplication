using System.Threading.Tasks;

namespace ToDoListApplication.Data.Repositories
{
    public interface IUserRepository
    {
        Task<UserEntity> GetUserAsync(string userName, string password);
    }
}
