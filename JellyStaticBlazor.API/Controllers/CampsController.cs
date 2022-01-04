using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JellyStaticBlazor.Common.Models;

namespace JellyStaticBlazor.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CampsController : ControllerBase
    {
        //[HttpGet]
        //public IActionResult GetCamps()
        //{
        //    return Ok(new { Moniker = "Atlanta 2020", Name = "Atlanta Code Camp" });
        //}
        //new Camp { Name = "Camp 01", EventDate = Convert.ToDateTime("01/01/2021")},
        //new Camp { Name = "Camp 02", EventDate = Convert.ToDateTime("02/02/2021")},

        List<Camp> camps = new List<Camp>()
        {
            new Camp { Name = "Camp 01"},
            new Camp { Name = "Camp 02"},
        };

        [HttpGet]
        public async Task<IActionResult> GetCamps()
        {
            return Ok(camps);
        }
    }
}
