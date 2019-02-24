using System;

namespace ToDoListApplication.Data
{
    public class ToDoEntity
    {
        public Guid Id { get; set; }

        public int UserId { get; set; }

        public bool IsCompleted { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime DateTimeCreated { get; set; }

        public DateTime? DateTimeCompleted { get; set; }
    }
}
