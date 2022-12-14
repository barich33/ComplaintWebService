using CWS.Service.categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace CWS.API.Controllers
{
    [ApiController]
    [Route("chuck")]
    public class ChuckController : ControllerBase
    { 
        private ICategoryService _categoryService;
        public ChuckController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

     
        [HttpGet("categories")]
        public  async Task<IActionResult> GetCategories()
        {
            var categories = await _categoryService.GetCategories();
            if(categories == null)
            {
                return NotFound();
            }
            return Ok(categories);
        }
       
    }
}
