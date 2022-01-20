using Microsoft.AspNetCore.Http;
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

            try
            {
                //var results = await _repository.Get()...
                return Ok(tests);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Error");
            }

        }
    }
}
