using Blog.DataAccess.Services.Concrete;
using Blog.Entities.Entities;
using Blog.UI.Filter;
using Blog.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog.UI.Controllers
{
    [ServiceFilter(typeof(LoginFilterAttribute))]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(User user)
        {
            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}