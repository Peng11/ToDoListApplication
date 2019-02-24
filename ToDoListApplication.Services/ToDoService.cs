using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoListApplication.Data;
using ToDoListApplication.Data.Repositories;

namespace ToDoListApplication.Services
{
    public interface IToDoService
    {
        Task<List<ToDoEntity>> GetList(int userId);
    }

    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public async Task<List<ToDoEntity>> GetList(int userId)
        {
            return await _toDoRepository.GetList(userId);
        }
    }
}
