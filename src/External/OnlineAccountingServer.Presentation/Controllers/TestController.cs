using Microsoft.AspNetCore.Mvc;
using OnlineAccountingServer.Presentation.Abstraction;

namespace OnlineAccountingServer.Presentation.Controllers
{
    public sealed class TestController : ApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Test Successful");
        }
    }
}
