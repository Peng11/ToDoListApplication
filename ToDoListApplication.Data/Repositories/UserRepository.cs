using System.Linq;
using System.Threading.Tasks;
using ToDoListApplication.Data.DbContext;

namespace ToDoListApplication.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<UserEntity> GetUserAsync(string userName, string password)
        {
            return await Task.Run(() => ToDoDbContext.UsersSet
                .FirstOrDefault(x => x.UserName == userName && x.Password == password));
        }
    }
}
