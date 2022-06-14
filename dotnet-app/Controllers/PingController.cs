using Microsoft.AspNetCore.Mvc;

namespace dotnet_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Pong") ;
        }
    }
}