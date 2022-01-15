using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JellyFishJuiceBlazorWebAssembly.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        List<TestDTO> tests = new List<TestDTO>()
        {
            new TestDTO { Name = "TestDTO 01"},
            new TestDTO { Name = "TestDTO 02"},
        };

        [HttpGet]
        public async Task<IActionResult> GetTests()
        {
            return Ok(tests);
        }
    }
}
