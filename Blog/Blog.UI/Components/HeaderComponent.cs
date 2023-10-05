using Blog.Entities.Entities;
using Blog.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blog.UI.Components
{
    public class HeaderComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var session = HttpContext.Session.GetString("account");
            if (session != null)
            {
                UserDM user = JsonConvert.DeserializeObject<UserDM>(session);

                return View(user);
            }  

            return View(null);
        }
    }
}
