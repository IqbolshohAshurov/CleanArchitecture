using System.Net;
using System.Text.Json;
using Application.Common.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using WebAPI.Responses;

namespace WebAPI.Middleware;
public class ErrorHandlerMiddleware
{
    private readonly ILogger<ErrorHandlerMiddleware> _logger;
    private readonly RequestDelegate _next;

    public ErrorHandlerMiddleware(ILogger<ErrorHandlerMiddleware> logger, RequestDelegate next)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception error)
        {

            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/problem+json";

            ErrorResponse? errorResponse = null;


            //var error = context.Features.Get<IExceptionHandlerFeature>()?.Error;

            errorResponse = error switch
            {
                InputValidationException validationException => new ErrorResponse()
                {
                    Title = "Validation Exception",
                    Detail = validationException.Message,
                    Errors = validationException.Errors,
                    Status = context.Response.StatusCode,
                    Instance = context.Request.Path.ToString()
                },
                InvalidPasswordOrLogin invalidPasswordOrLogin => new ErrorResponse()
                {
                  Title  = "Input incorrect password or login",
                  Detail = invalidPasswordOrLogin.Message,
                  Status = context.Response.StatusCode,
                  Instance = context.Request.Path.ToString()
                },
                _ => new ErrorResponse()
                {
                    Title = "Unhandled Exception",
                    Detail = "Internal Server Error",
                    Status = context.Response.StatusCode,
                    Instance = context.Request.Path.ToString()
                }
            };

            await context.Response.WriteAsync(JsonSerializer.Serialize(errorResponse));

        }
    }
}