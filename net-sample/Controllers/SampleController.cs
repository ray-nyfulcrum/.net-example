using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace net_sample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        [HttpGet("helloworld")]
        public string GetHelloWorld()
        {
            return "hello world!";
        }

        [HttpGet("ping")]
        public string GetPing()
        {
            return "pong!";
        }
    }
}