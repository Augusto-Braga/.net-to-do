using Microsoft.AspNetCore.Mvc;

namespace to_do_api.Controllers
{
  [Route("/")]
  [ApiController]
  public class HomeController : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok("Hello World");
    }
  }
}