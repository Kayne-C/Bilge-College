using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Bilge_College.Filters
{
    public class LoggedUserAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            string userId = context.HttpContext.Session.GetString("userId");

            if (string.IsNullOrEmpty(userId)) context.Result = new RedirectToRouteResult(new { action = "Index", controller = "Login", area = "Student" });
        }
    }
}
