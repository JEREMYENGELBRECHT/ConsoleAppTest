using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
//using System.Web.Http;
using Microsoft.AspNetCore.Mvc;


namespace ConsoleAppTest.Controllers
{
    [Route("api/tester")]
    public class TesterController : ControllerBase
    {
        [HttpGet]
        [EnableCors("MyPolicy")]
        public IActionResult GetTester()
        {

            //return Request.CreateResponse("im here");
            return Ok("im here");
        }
    }
}
