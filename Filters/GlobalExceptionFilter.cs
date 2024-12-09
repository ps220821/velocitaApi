using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.EntityFrameworkCore;
using System.Net;
using velocitaApi.models;

namespace velocitaApi.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            // Log the exception (you can inject a logger service here)
            var exception = context.Exception;

            var errorResponse = new ErrorResponse
            {
                StatusCode = (int)HttpStatusCode.InternalServerError,
                Message = "An unexpected error occurred",
                Details = exception.Message
            };

            // Set the result to a JsonResult with the error information
            context.Result = new JsonResult(errorResponse)
            {
                StatusCode = (int)HttpStatusCode.InternalServerError
            };

            // Mark the exception as handled so it doesn't propagate further
            context.ExceptionHandled = true;
        }
    }

    // Error response structure
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}