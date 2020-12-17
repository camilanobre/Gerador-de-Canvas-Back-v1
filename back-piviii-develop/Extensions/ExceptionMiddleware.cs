using System;
using System.Net;
using System.Threading.Tasks;
using back_piviii.BLL.Exceptions;
using back_piviii.Extensions.Responses;
using back_piviii.Utils;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace back_piviii.Extensions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerManager _logger;

        public ExceptionMiddleware(RequestDelegate next, ILoggerManager logger)
        {
            _logger = logger;
            _next = next;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await _next.Invoke(httpContext);
            }
            catch(NotFoundException ex)
            {
                _logger.LogError($"Erro: {ex.Message}");

                httpContext.Response.StatusCode = 404;
            }
            catch(Exception ex)
            {
                _logger.LogError($"Erro: {ex.Message}");

                httpContext.Response.StatusCode = 500;
            }            

            if (!httpContext.Response.HasStarted)
            {
                httpContext.Response.ContentType = "application/json";
                
                var response = new ApiResponse(httpContext.Response.StatusCode);

                var json = JsonConvert.SerializeObject(response);

                await httpContext.Response.WriteAsync(json);
            }   
            
        }
    }
}