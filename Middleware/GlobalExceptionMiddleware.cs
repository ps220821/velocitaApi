using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Mysqlx;
namespace velocitaApi.Middleware
{
    public class GlobalExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<GlobalExceptionMiddleware> _logger;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogger<GlobalExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);  // Call the next middleware in the pipeline
            }
            catch (Exception ex)
            {
                ErrorResponse errorResponse = null;
                _logger.LogError(ex, "An unexpected error occurred");

                // Handle the error response
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                if (httpContext.Response.StatusCode == null && ex.Message == null)
                {

                    errorResponse = new ErrorResponse();
                }
                else
                {
                    errorResponse = new ErrorResponse(
                  httpContext.Response.StatusCode,
                  ex.Message,
                  "An unexpected error occurred"
              );
                }


                // Return the error response
                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(errorResponse));
            }
        }
    }

    // ErrorResponse class for the error response structure
    public class ErrorResponse
    {
        public int StatusCode { get; private set; }
        public string Message { get; private set; }
        public string Details { get; private set; }

        public ErrorResponse()
        {
            StatusCode = 500;
            Message = "An unexpected error occurred";
            Details = string.Empty;
        }

        public ErrorResponse(int statusCode, string message, string details)
        {
            StatusCode = statusCode;
            Message = message;
            Details = details;
        }
    }
}