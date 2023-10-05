using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Blog.UI.Filter
{
    public class LoginFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var session = context.HttpContext.Session.GetString("account");

            if (string.IsNullOrEmpty(session))
                context.Result = new RedirectResult("/login");

            base.OnActionExecuting(context);
        }
    }
}
