using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JellyStaticBlazor.Common.Models;
using JellyStaticBlazor.API.Data;

namespace JellyStaticBlazor.API.Controllers
{
	[Route("[controller]")]
	[ApiController]
	public class PersonsController : Controller
    {
		PeopleService peopleService;
        
		public PersonsController(PeopleService _peopleService)
		{
			peopleService = _peopleService;
		}

		[HttpGet]
		public async Task<List<Person>> GetAll()
		{
			var result = await peopleService.GetAll(new GetAllPeopleRequest());
			return result.People;
		}

		[HttpGet("{Id}/getbyid")]
		public async Task<Person> GetPersonById(int Id)
		{
			var getPersonByIdRequest = new GetPersonByIdRequest { Id = Id };
			return await peopleService.GetPersonById(getPersonByIdRequest);
		}
    }
}
