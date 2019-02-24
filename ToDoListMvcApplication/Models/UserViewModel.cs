using System.Collections.Generic;

namespace ToDoListMvcApplication.Models
{
    public class UserViewModel
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public ToDoViewModel ToDo { get; set; }

        public List<ToDoViewModel> ToDos { get; set; } 
    }
}