using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ToDoListApplication.Data.DbContext;

namespace ToDoListApplication.Data.Repositories
{
    public class ToDoRepository : IToDoRepository
    {
        public async Task<ToDoEntity> Add(ToDoEntity todo)
        {
            await Task.Run(() => ToDoDbContext.ToDosSet.Add(todo));

            return todo;
        }

        public async Task<ToDoEntity> Complete(Guid todoId)
        {
            var todo = await Task.Run(() => ToDoDbContext.ToDosSet.FirstOrDefault(x => x.Id == todoId));

            todo.IsCompleted = true;
                        
            return todo;
        }

        public async Task Delete(Guid todoId)
        {
            await Task.Run(() => ToDoDbContext.ToDosSet.RemoveAll(x => x.Id == todoId));
        }

        public async Task<List<ToDoEntity>> GetList(int userId)
        {
            Thread.Sleep(300); //Note: remove after cookie implementation.
            return await Task.Run(() => ToDoDbContext.ToDosSet.Where(x => x.UserId == userId).ToList());
        }

        public async Task Update(ToDoEntity updatedTodo)
        {
            await Task.Run(() => {
                var todo = ToDoDbContext.ToDosSet.RemoveAll(x => x.Id == updatedTodo.Id);

                ToDoDbContext.ToDosSet.Add(updatedTodo);
            });
        }
    }
}
