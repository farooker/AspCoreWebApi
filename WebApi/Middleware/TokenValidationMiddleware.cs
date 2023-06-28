using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using WebApi.Constant;
using WebApi.Utils;

namespace WebApi.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class TokenValidationMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenValidationMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                //var token = httpContext.Request.Headers["Authorization"];

                //if (string.IsNullOrEmpty(token))
                //{
                //    throw new ExceptionHandling((int)HttpStatusCodes.Unauthorized, "Unauthorized");

                //}
                //if (!IsValidToken(token))
                //{
                //    throw new ExceptionHandling((int)HttpStatusCodes.Forbidden, "Forbidden");
                //}
                await _next(httpContext);
            }
            catch (ExceptionHandling e)
            {
                httpContext.Response.StatusCode = e.ErrorCode;
                httpContext.Response.ContentType = "application/json";
                var response = e.ExceptionResponse(e);
                var json = JsonConvert.SerializeObject(response);
                await httpContext.Response.WriteAsync(json);
                return;
            }
        }
        private bool IsValidToken(string token)
        {
            // Implement your token validation logic here
            // Return true if the token is valid, otherwise return false

            // Example: Check if the token is equal to a specific value
            return token == "valid_token";
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class TokenValidationMiddlewareExtensions
    {
        public static IApplicationBuilder UseTokenValidationMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TokenValidationMiddleware>();
        }
    }
}
