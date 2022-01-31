using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp3.Controllers
{
    [ApiController]
    [Route("test/[action]")]
    public class TestController : ControllerBase
    {
            
        public string Get()
        {
            return "Hello World form Test";
        }

        public string Get2()
        {
            return "Hello World form Test2";
        }

    }
}
