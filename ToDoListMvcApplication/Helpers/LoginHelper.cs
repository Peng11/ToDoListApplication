using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoListApplication.Data;
using ToDoListMvcApplication.Models;

namespace ToDoListMvcApplication.Handlers
{
    public static class LoginHelper
    {
        public static UserViewModel GetUserViewModel(int userId, List<ToDoEntity> toDoList)
        {
            var toDoViewModels = toDoList.Select(x => new ToDoViewModel
            {
                Id = x.Id,
                UserId = x.UserId,
                DateTimeCompleted = x.DateTimeCompleted,
                DateTimeCreated = x.DateTimeCreated,
                Description = x.Description,
                IsCompleted = x.IsCompleted,
                Title = x.Title
            }).ToList();

            var model = new UserViewModel
            {
                UserId = userId,
                ToDos = toDoViewModels,
                ToDo = null
            };

            return model;
        }
    }
}
