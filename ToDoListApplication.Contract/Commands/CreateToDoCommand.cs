using NServiceBus;
using System;

namespace ToDoListApplication.Contract
{
    public class CreateToDoCommand : ICommand
    {
        public Guid Id { get; set; }

        public int UserId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
