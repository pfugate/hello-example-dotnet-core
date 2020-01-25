using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloExample.Controllers
{
    [Route("hello")]
    [ApiController]
    public class HelloController : ControllerBase
    {
    
        private readonly IHelloAppService _appService;
        public HelloController(IHelloAppService appService)
        {
            _appService = appService;
        }
        
        [HttpGet("{name}")]
        public IActionResult Get(string name)
        {
            return Ok(_appService.SayHello(name));
        }
    }
}
