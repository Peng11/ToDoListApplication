using NServiceBus;
using System.Threading.Tasks;
using ToDoListApplication.Contract;
using ToDoListApplication.Data.Repositories;

namespace ToDoListMvcApplication.Controllers
{
    public class RemoveToDoCommandHandler :
        IHandleMessages<RemoveToDoCommand>
    {
        private readonly IToDoRepository _toDoRepository;

        public RemoveToDoCommandHandler(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public Task Handle(RemoveToDoCommand message, IMessageHandlerContext context)
        {
            _toDoRepository.Delete(message.Id);

            return Task.CompletedTask;
        }
    }
}
