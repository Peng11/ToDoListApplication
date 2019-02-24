using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NServiceBus;
using ToDoListApplication.Contract;
using ToDoListApplication.Services;
using ToDoListMvcApplication.Handlers;
using ToDoListMvcApplication.Models;

namespace ToDoListMvcApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEndpointInstance _endpointInstance;
        private readonly IUserService _userService;
        private readonly IToDoService _toDoService;

        public HomeController(IEndpointInstance endpointInstance,
            IUserService userService,
            IToDoService toDoService)
        {
            _endpointInstance = endpointInstance;
            _userService = userService;
            _toDoService = toDoService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {
            var command = new CreateToDoCommand();

            await _endpointInstance.Send(command).ConfigureAwait(false);

            var user = await _userService.UserLogIn(userName, password);
            
            if (user == null)
                return RedirectToAction("Index");

            TempData["UserName"] = user.UserName;

            return RedirectToAction("ToDoList", new { userId = user.Id });
        }

        [HttpGet]
        public async Task<IActionResult> ToDoList(int userId)
        {
            var toDoList = await _toDoService.GetList(userId);

            var model = LoginHelper.GetUserViewModel(userId, toDoList);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ToDoList(string userName, string password)
        {
            var user = await _userService.UserLogIn(userName, password);

            if (user == null)
                return RedirectToAction("Index");

            ViewBag.UserInformation = $"Hello {user.UserName}, here is your todo list:";
            
            var toDoList = await _toDoService.GetList(user.Id);

            var model = LoginHelper.GetUserViewModel(user.Id, toDoList);

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
