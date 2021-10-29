using System;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace OzonEdu.MerchandiseService.Infrastructure.Middlewares
{
    public class ResponseLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ResponseLoggingMiddleware> _logger;

        public ResponseLoggingMiddleware(RequestDelegate next, ILogger<ResponseLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            await LogResponse(context);
            await _next(context);
        }

        private async Task LogResponse(HttpContext context)
        {
            try
            {
                if ((!context.Request.ContentType?.StartsWith("application/grpc")) ?? true)
                    await Task.Run(() =>
                    {
                        var route = string.Join(Environment.NewLine, context.Request.Path);
                        var headers = string.Join(',', context.Response.Headers);

                        _logger.LogInformation("Response logged");
                        _logger.LogInformation($"Route = {route}");
                        _logger.LogInformation($"Headers = {headers}");
                    });
            }
            catch (Exception e)
            {
                _logger.LogError(e, "Could not log response");
            }
        }
    }
}