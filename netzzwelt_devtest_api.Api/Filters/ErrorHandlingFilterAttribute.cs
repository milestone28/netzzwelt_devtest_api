using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace BuberDinner.Api.Filters
{
    public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {


         

            var exception = context.Exception;
            context.Result = new ObjectResult(new
            {
                message = "Invalid username or password."
            })
            {
                StatusCode = (int?)HttpStatusCode.NotFound,
            };

            context.ExceptionHandled = true;

        }
    }
}
