 
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ITMCode.Piatnica.Api.Exceptions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionMiddleware> _logger;

        public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
                IsForbidden(httpContext);

            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(httpContext, ex, _logger);
            }
        }

        private void IsForbidden(HttpContext context)
        {
            if (context.Response.StatusCode == (int)HttpStatusCode.Forbidden)
                throw new MyForbiddenException($"{context.Request.Path} is forbidden");
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception, ILogger<ExceptionMiddleware> logger)
        {
            context.Response.ContentType = "application/json";
            ErrorResponse errorResponse = new ErrorResponse();

            new Switch(exception)
                .Case<MyNotFoundException>(action =>
                {
                    logger.LogWarning($"{exception}");
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    errorResponse.StatusCode = context.Response.StatusCode.ToString();
                    errorResponse.Message = exception.Message;
                    return;
                })
                .Case<MyNotValidException>(action =>
                {
                    logger.LogWarning($"{exception}");
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    errorResponse.StatusCode = context.Response.StatusCode.ToString();
                    var myNotValidException = exception as MyNotValidException; 
                    errorResponse.Message = myNotValidException.Message;
                    errorResponse.Errors= myNotValidException.ValidationErrors;
                    return;
                })     
                .Case<MyForbiddenException>(action =>
                {
                    logger.LogWarning($"{exception}");
                    context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                    errorResponse.StatusCode = context.Response.StatusCode.ToString();
                    var myNotValidException = exception as MyForbiddenException; 
                    errorResponse.Message = myNotValidException.Message;
                     return;
                })
                .Case<MyUnauthorizedException>(action =>
                {
                    logger.LogError($"{exception}");
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    errorResponse.StatusCode = context.Response.StatusCode.ToString();
                    var myNotValidException = exception as MyUnauthorizedException;
                    errorResponse.Message = myNotValidException.Message;
                    return;

                }).Case<MyLoginFailedException>(action =>
                {
                    logger.LogError($"{exception}");
                    context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                    var myNotValidException = exception as MyLoginFailedException;
                    errorResponse.Message = $"{myNotValidException.Message} {myNotValidException.InnerException}";
                    errorResponse.StatusCode = myNotValidException.InternalLoginError;
                    return;
                }).Case<MyRegisterFailedException>(action =>
                {
                    logger.LogError($"{exception}");
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    var myRegisterFailedException = exception as MyRegisterFailedException;
                    errorResponse.Message = myRegisterFailedException.Message;
                    errorResponse.StatusCode = context.Response.StatusCode.ToString();
                    errorResponse.SetOnlyMessageError(myRegisterFailedException.Errors);
                    return;
                })
                .Case<Exception>(action =>
                {
                    logger.LogCritical($"{exception}");
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    errorResponse.StatusCode = context.Response.StatusCode.ToString();
                     errorResponse.Message = $"{exception.Message} {exception.InnerException}";

                    return;

                });
            return context.Response.WriteAsync(JsonConvert.SerializeObject(errorResponse));
        }
    }
}
