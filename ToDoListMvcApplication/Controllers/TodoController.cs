using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NServiceBus;
using ToDoListApplication.Contract;
using ToDoListApplication.Services;
using ToDoListMvcApplication.Models;

namespace ToDoListMvcApplication.Controllers
{
    public class TodoController : Controller
    {
        private readonly IEndpointInstance _endpointInstance;
        private readonly IUserService _userService;
        private readonly IToDoService _toDoService;

        public TodoController(IEndpointInstance endpointInstance,
            IUserService userService,
            IToDoService toDoService)
        {
            _endpointInstance = endpointInstance;
            _userService = userService;
            _toDoService = toDoService;
        }

        [HttpGet]
        public IActionResult Add(int userId)
        {
            var model = new ToDoViewModel {
                UserId = userId
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult Update(ToDoViewModel model)
        {
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SaveUpdate(ToDoViewModel model)
        {
            //TODO: AutoMapper
            var command = new UpdateToDoCommand
            {
                Id = model.Id,
                UserId = model.UserId,
                Title = model.Title,
                Description = model.Description,
                IsCompleted = model.IsCompleted
            };

            await _endpointInstance.Send(command).ConfigureAwait(false);
            
            return RedirectToAction("ToDoList", "Home", new { userId = model.UserId });
        }

        [HttpPost]
        public async Task<IActionResult> Add(ToDoViewModel model)
        {
            //TODO: AutoMapper
            var command = new CreateToDoCommand
            {
                Id = Guid.NewGuid(),
                Title = model.Title,
                UserId = model.UserId,
                Description = model.Description
            };

            await _endpointInstance.Send(command).ConfigureAwait(false);

            return RedirectToAction("ToDoList", "Home", new { userId = model.UserId });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int userId, Guid id)
        {
            var command = new RemoveToDoCommand
            {
                Id = id
            };

            await _endpointInstance.Send(command).ConfigureAwait(false);

            return RedirectToAction("ToDoList", "Home", new { userId = userId });
        }

        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            var command = new CreateToDoCommand();

            await _endpointInstance.Send(command).ConfigureAwait(false);

            var user = await _userService.UserLogIn(userName, password);

            if (user == null)
                return RedirectToAction("Index");

            var toDoList = await _toDoService.GetList(user.Id);

            var model = new UserViewModel();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> ToDoList()
        {
            ViewBag.UserInformation = $"Hello {ViewBag.UserName}, here is your todo list:";

            var model = new UserViewModel();

            var command = new CreateToDoCommand();

            await _endpointInstance.Send(command).ConfigureAwait(false);

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
