using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeWebAPI.Filters
{
    public class CustomAuthFilter : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.Request.Headers.ContainsKey("AuthKey"))
            {
                context.Result = new UnauthorizedObjectResult(new
                {
                    Message = "Authorization Failed. AuthKey is missing."
                });

                return;
            }

            var authKey = context.HttpContext.Request.Headers["AuthKey"].ToString();

            if (authKey != "12345")
            {
                context.Result = new UnauthorizedObjectResult(new
                {
                    Message = "Invalid AuthKey."
                });
            }
        }
    }
}