﻿using System;
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
        public JsonResult GetCities()
        {
            return new JsonResult(new List<object>()
            {
                new {id=1, Name="Phoenix"},
                new {id=1, Name="Antwerp"}
            });
        }
    }
}
