using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace WebAppKeyVaultSample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TestController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IActionResult Get()
        {
            var value = _configuration.GetValue<string>("MySecret");
            return Ok(value);
        }
    }
}