using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace CapitalPlacementCRUD.Extensions
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext Context)
        {
            try
            {
               await _next(Context);
            }
            catch(Exception error)
            {
                var response = Context.Response;
                response.ContentType = "application/json";
                switch (error)
                {
                    case ApplicationException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    case KeyNotFoundException e:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    default:
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                }
                var result = JsonSerializer.Serialize(new { Statucode = 500, Message = error.Message });
                await response.WriteAsync(result);
            }
        }
    }
}
