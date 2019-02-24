using NServiceBus;
using System;

namespace ToDoListApplication.Contract
{
    public class RemoveToDoCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}
