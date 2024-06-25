using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace csmcodes
{
    public class HttpSign
    {
        private readonly ILogger<HttpSign> _logger;

        public HttpSign(ILogger<HttpSign> logger)
        {
            _logger = logger;
        }

        [Function("HttpSign")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
