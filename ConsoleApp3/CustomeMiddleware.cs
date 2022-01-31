using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class CustomeMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello custom 1 \n ");

            await next(context);
            await context.Response.WriteAsync("Hello custom 2 \n ");
        }
    }
}
