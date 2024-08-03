using Microsoft.AspNetCore.Mvc;

namespace project2.project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        [HttpGet]
        [Route("getValue")]
        public ActionResult getValue()
        {
            return Ok("Load Balancing to Second Solution");
        }
    }
}
