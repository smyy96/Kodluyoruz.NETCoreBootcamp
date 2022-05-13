using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Catalog.API.Filters
{
    public class CustomExceptionAttribute: ExceptionFilterAttribute
    {
        public string ErrorMessage { get; set; }
        public override void OnException(ExceptionContext context) // Action hata verirse 
        {
            string errorMessage = ErrorMessage ?? context.Exception.Message; 
            context.Result = new BadRequestObjectResult(new { message = errorMessage });
            base.OnException(context);
        }
    }
}
