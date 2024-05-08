using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.NewFolder;

namespace WebApplication5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "API is working";
        }
        [HttpPost]
        public ActionResult Post(Person person) {
            return Ok($"Received:{person.Name}");
        }
    }
}
