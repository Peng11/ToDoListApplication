using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoListApplication.Data;
using ToDoListApplication.Data.Repositories;

namespace ToDoListApplication.Services
{
    public interface IToDoService
    {
        Task<List<ToDoEntity>> GetList(int userId);

        Task<ToDoEntity> Add(int userId, ToDoEntity todo);

        Task<ToDoEntity> Update(int userId, ToDoEntity todo);

        Task Delete(int userId, int todoId);

        Task<ToDoEntity> Complete(int userId, int todoId);
    }

    public class ToDoService : IToDoService
    {
        private readonly IToDoRepository _toDoRepository;

        public ToDoService(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public Task<ToDoEntity> Add(int userId, ToDoEntity todo)
        {
            throw new NotImplementedException();
        }

        public Task<ToDoEntity> Complete(int userId, int todoId)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int userId, int todoId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ToDoEntity>> GetList(int userId)
        {
            return await _toDoRepository.GetList(userId);
        }

        public Task<ToDoEntity> Update(int userId, ToDoEntity todo)
        {
            throw new NotImplementedException();
        }
    }
}
