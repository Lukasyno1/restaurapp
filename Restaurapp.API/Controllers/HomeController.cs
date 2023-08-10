using Microsoft.AspNetCore.Mvc;

namespace Restaurapp.API.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"Server is alive!");
        }
    }
}
