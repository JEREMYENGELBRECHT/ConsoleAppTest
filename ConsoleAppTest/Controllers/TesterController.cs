using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ConsoleAppTest.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;


namespace ConsoleAppTest.Controllers
{

    [Route("api/tester")]
    [AllowAnonymous]
    public class TesterController : ControllerBase
    {
        public readonly IService Service;

        public TesterController(IService service)
        {
            Service = service;
        }

        [HttpGet]
        [EnableCors("MyPolicy")]
        public IActionResult GetTester()
        {

            Service.updateData();

            //return Request.CreateResponse(HttpStatusCode.OK,"thank you");
            return Ok("");
        }
    }
}
