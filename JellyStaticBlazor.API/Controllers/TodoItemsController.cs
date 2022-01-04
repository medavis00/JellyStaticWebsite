using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JellyStaticBlazor.API.Controllers
{
    [Route("api/TodoItems")]
    public class TodoItemsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTodoItems()
        {
            return Ok(new { id = "1", Name = "My New Todo Item", IsComplete = false });
        }
    }
}
