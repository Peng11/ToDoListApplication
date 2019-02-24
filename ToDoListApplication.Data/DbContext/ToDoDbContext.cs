using System;
using System.Collections.Generic;

namespace ToDoListApplication.Data.DbContext
{
    public class ToDoDbContext
    {
        public static List<ToDoEntity> ToDosSet { get; set; } = new List<ToDoEntity> {
            new ToDoEntity
            {
                UserId = 1,
                Id = Guid.NewGuid(),
                DateTimeCompleted = null,
                DateTimeCreated = DateTime.Now.AddDays(-1),
                Description = "Peng Test Deloitte",
                IsCompleted = false,
                Title = "Peng Gao Test"
            },
            new ToDoEntity
            {
                UserId = 1,
                Id = Guid.NewGuid(),
                DateTimeCompleted = null,
                DateTimeCreated = DateTime.Now.AddDays(-2),
                Description = "Peng Test Deloitte 2",
                IsCompleted = false,
                Title = "Peng Gao Test 2"
            }
        };

        public static List<UserEntity> UsersSet => new List<UserEntity>
                {
                    new UserEntity
                    {
                        Id = 1,
                        UserName = "test",
                        Password = "pwd123"
                    }
                };
    }
}
