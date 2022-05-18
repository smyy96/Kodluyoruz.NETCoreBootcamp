using Bionluk.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BionlukAPI.Filters
{
    public class IsExistsOperation : IAsyncActionFilter
    {
        private readonly IUserService userService;

        public IsExistsOperation(IUserService userService)
        {
            this.userService = userService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ActionArguments.ContainsKey("id"))
            {
                context.Result = new BadRequestObjectResult("id is required");
            }
            else
            {
                var id = (int)context.ActionArguments["id"];
                if (!await userService.IsUserExists(id))
                {
                    context.Result = new NotFoundObjectResult(new { message = "Kullanıcı bulunamadı." });
                }
                else
                {
                    await next.Invoke();
                }

                
            }

            
        }
    }
}
