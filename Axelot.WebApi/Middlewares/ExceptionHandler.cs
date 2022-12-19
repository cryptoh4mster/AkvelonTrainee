using Axelot.Core.Exceptions;
using Newtonsoft.Json;
using System.Net;

namespace Axelot.WebApi.Middlewares
{
    public class ExceptionHandler
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandler> _logger;

        public ExceptionHandler(RequestDelegate next, ILogger<ExceptionHandler> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);

                switch (exception)
                {
                    case EntityNotFoundException entityNotFoundException:                    
                        await WriteResponse(entityNotFoundException, context, HttpStatusCode.BadRequest);
                        break;
                    default:
                        await WriteResponse(exception, context, HttpStatusCode.InternalServerError);
                        break;
                }
            }
        }

        private async Task WriteResponse<T>(T exception, HttpContext context, HttpStatusCode statusCode) where T : Exception
        {
            var response = context.Response;

            response.StatusCode = (int)statusCode;
            context.Response.ContentType = "application/json";
            var result = JsonConvert.SerializeObject(exception);

            await context.Response.WriteAsync(result);
        }
    }
}
