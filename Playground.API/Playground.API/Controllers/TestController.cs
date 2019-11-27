using Microsoft.AspNetCore.Mvc;
using Playground.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.API.Controllers
{
    [Route("test")]
    public class TestController : ControllerBase
    {
        private readonly ITestService _testService;

        public TestController(ITestService testService)
        {
            _testService = testService;
        }

        [Route("")]
        [HttpGet]
        public async Task<IActionResult> GetTest(string name)
        {
            var response = await _testService.Test(name);
            return Ok(response);
        }
    }
}
