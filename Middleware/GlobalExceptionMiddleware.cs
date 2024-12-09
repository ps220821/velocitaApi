using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
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
                _logger.LogError(ex, "An unexpected error occurred");

                // Handle the error response
                httpContext.Response.ContentType = "application/json";
                httpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var errorResponse = new ErrorResponse
                {
                    Message = "An unexpected error occurred",
                    Details = ex.Message, // Optional: In development, we may want to show the exception message
                    StatusCode = httpContext.Response.StatusCode
                };

                // Return the error response
                await httpContext.Response.WriteAsync(JsonConvert.SerializeObject(errorResponse));
            }
        }
    }

    // ErrorResponse class for the error response structure
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}