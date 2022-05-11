using Catalog.Business;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.API.Filters
{
    public class IsExistOperation : IAsyncActionFilter
    {
        private readonly IProductService productService;

        public IsExistOperation(IProductService productService)
        {
            this.productService=productService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ActionArguments.ContainsKey("id"))
            {
                context.Result = new BadRequestObjectResult("id is required");
            }

            var id = (int)context.ActionArguments["id"];
            if (!await productService.IsProductExists(id))
            {
                context.Result=new NotFoundObjectResult(new { message = $"{id} id'li ürün bulunamadı." });
            }
            else
            {
                await next.Invoke();
            }

            
        }
    }
}
