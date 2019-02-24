using NServiceBus;
using System;
using System.Threading.Tasks;
using ToDoListApplication.Contract;
using ToDoListApplication.Data;
using ToDoListApplication.Data.Repositories;

namespace ToDoListMvcApplication.Controllers
{
    public class UpdateToDoCommandHandler :
        IHandleMessages<UpdateToDoCommand>
    {
        private readonly IToDoRepository _toDoRepository;

        public UpdateToDoCommandHandler(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public Task Handle(UpdateToDoCommand message, IMessageHandlerContext context)
        {
            var todoEntity = new ToDoEntity
            {
                DateTimeCreated = DateTime.Now,
                Id = message.Id,
                UserId = message.UserId,
                Title = message.Title,
                Description = message.Description,
                IsCompleted = message.IsCompleted,
                DateTimeCompleted = GetDateTimeCompleted(message.IsCompleted)
            };

            _toDoRepository.Update(todoEntity);

            return Task.CompletedTask;
        }

        private DateTime? GetDateTimeCompleted(bool isCompleted)
        {
            if (isCompleted)
                return DateTime.Now;

            return null;
        }
    }
}
