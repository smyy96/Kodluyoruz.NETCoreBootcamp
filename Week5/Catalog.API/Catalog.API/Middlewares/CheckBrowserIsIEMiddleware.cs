namespace Catalog.API.Middlewares
{
    public class CheckBrowserIsIEMiddleware
    {
        private readonly RequestDelegate _next;

        public CheckBrowserIsIEMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context) // internet explorerda gelen requesti kontrol et
        {
            var isIE = context.Request.Headers["User-Agent"].Any(value => value.Contains("Trident"));
            context.Items["IE"] = isIE;// items true veya false olacak
            context.Items["message"] = "Bu api istemcisi; IE olamaz";
            //items; bir request'e eklenecek özel bilgilerdir.
            await _next.Invoke(context);
        }
    }
}
