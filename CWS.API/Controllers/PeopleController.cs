using CWS.Service.categories;
using CWS.Service.People;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CWS.API.Controllers
{
    [ApiController]
    [Route("swapi")]
    public class PeopleController : ControllerBase
    { 
        private IPeopleService _peopleService;
        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }

     
        [HttpGet("people")]
        public  async Task<IActionResult> GetAllPeople()
        {
            var categories = await _peopleService.GetAllPeoples();
            if(categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }
       
    }
}
