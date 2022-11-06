using System.Net;
using Api.Exceptions;

namespace Api.Middlewares;

public class MyCustomExceptionMiddleware : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
//            await next.Invoke(context);
            throw new Exception("Random exception");
        }
        catch (Exception exception)
        {

            if (exception is MyCustomException myCustomException)
            {
                context.Response.StatusCode = (int) MapStatusCode(myCustomException.Code);
                await context.Response.WriteAsJsonAsync(new { myCustomException.Message, myCustomException.Code });

                return;
            }

            context.Response.StatusCode = 500;
            await context.Response.WriteAsJsonAsync(new { exception.Message });
        }
    }

    private static HttpStatusCode MapStatusCode(string code) => code switch
    {
        "420" => HttpStatusCode.NotAcceptable,
        _ => HttpStatusCode.InternalServerError
    };
}