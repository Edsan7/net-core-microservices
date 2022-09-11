using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlatformsController : ControllerBase
    {
        public PlatformsController()
        {

        }


        [HttpPost]
        public ActionResult TestInboundConnection()
        {
            Console.WriteLine("---> Inbound POST # Command Service");

            return Ok("Inbound test of from Platforms Controller");
        }

    }
}
