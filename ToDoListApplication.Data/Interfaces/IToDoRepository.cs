using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDoListApplication.Data.Repositories
{
    public interface IToDoRepository
    {
        Task<List<ToDoEntity>> GetList(int userId);

        Task<ToDoEntity> Add(ToDoEntity todo);

        Task Update(ToDoEntity todo);

        Task Delete(Guid todoId);
    }
}
