using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace aspCoreAPI.Controllers
{
    [Route("api/cities")]//or [Route("api/[controller]")]
    public class CitiesController : Controller
    {
        [HttpGet()]//or [HttpGet("api/cities")]
        public IActionResult GetCities()//JsonResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]//[HttpGet("api/cities/{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);

            if (cityToReturn == null)
            {
                return NotFound();
            }

            return Ok(cityToReturn);
        }
    }
}
