using Blog.Business.Manager;
using Blog.Entities.Entities;
using Blog.Entities.Models;
using Blog.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blog.UI.Controllers
{
    public class UserController : Controller
    {
        private IUserManager userManager;
        public UserController(IUserManager _userManager)
        {
            this.userManager = _userManager;
        }

        public IActionResult Profil()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(UserModel user)
        {
            var _user = new User
            {
                Email = user.Email,
                Name = user.Name,
                Password = user.Password
            };

            userManager.Add(_user);

            return View();
        }

        [Route("~/login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserDM user)
        {
            var _user = userManager.Login(user);

            if (_user != null)
            {
                HttpContext.Session.SetString("account", JsonConvert.SerializeObject(
                    new UserDM { Email = _user.Email,Name = _user.Name}));

                return RedirectToAction("Index", "Home");
            }  
            else
                ViewData["Error"] = "Kullanıcı giriş bilgileriniz hatalı!";
                
            return View("Login");

        }

    }
}
