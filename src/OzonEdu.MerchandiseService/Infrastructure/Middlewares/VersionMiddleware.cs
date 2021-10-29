using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace OzonEdu.MerchandiseService.Infrastructure.Middlewares
{
    public class VersionMiddleware
    {
        public VersionMiddleware(RequestDelegate next)
        {
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var version = Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "no version";
            var name = Assembly.GetExecutingAssembly().GetName().Name ?? "what";
            var response = JsonSerializer.Serialize(
                new
                {
                    Version = version,
                    ServiceName = name
                },
                new JsonSerializerOptions()
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
                });
            context.Response.ContentType = System.Net.Mime.MediaTypeNames.Application.Json;
            await context.Response.WriteAsync(response);
        }
    }
}