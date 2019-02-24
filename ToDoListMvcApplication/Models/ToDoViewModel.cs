using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoListMvcApplication.Models
{
    public class ToDoViewModel
    {
        public Guid Id { get; set; }

        public int UserId { get; set; }

        public bool IsCompleted { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        [DisplayName("Last Modified")]
        public DateTime DateTimeCreated { get; set; }

        [DisplayName("Date Completed")]
        [MaxLength(100)]
        public DateTime? DateTimeCompleted { get; set; }
    }
}