using NServiceBus;
using System;
using System.Threading.Tasks;
using ToDoListApplication.Contract;
using ToDoListApplication.Data;
using ToDoListApplication.Data.Repositories;

namespace ToDoListMvcApplication.Controllers
{
    public class AddToDoCommandHandler :
        IHandleMessages<CreateToDoCommand>
    {
        private readonly IToDoRepository _toDoRepository;

        public AddToDoCommandHandler(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public Task Handle(CreateToDoCommand message, IMessageHandlerContext context)
        {
            var todoEntity = new ToDoEntity
            {
                DateTimeCreated = DateTime.Now,
                Id = message.Id,
                UserId = message.UserId,
                Title = message.Title,
                Description = message.Description,
                IsCompleted = false,
                DateTimeCompleted = null
            };

            _toDoRepository.Add(todoEntity);

            return Task.CompletedTask;
        }
    }
}
