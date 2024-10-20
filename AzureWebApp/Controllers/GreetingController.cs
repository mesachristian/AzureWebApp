using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Greeting()
        {
            return Ok("Hi my name is Christian :3");
        }
    }
}
