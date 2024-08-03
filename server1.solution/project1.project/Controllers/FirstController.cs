using Microsoft.AspNetCore.Mvc;

namespace project1.project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirstController : ControllerBase
    {
        [HttpGet]
        [Route("getValue")]
        public ActionResult getValue()
        {
            return Ok("Load Balancing to First Solution");
        }
    }
}
