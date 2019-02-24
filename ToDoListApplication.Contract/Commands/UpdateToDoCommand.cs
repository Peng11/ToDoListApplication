using NServiceBus;
using System;

namespace ToDoListApplication.Contract
{
    public class UpdateToDoCommand : ICommand
    {
        public int UserId { get; set; }

        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; }
    }
}
