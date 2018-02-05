using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Interview.WebApp.Controllers
{
    public class HealthcheckController : Controller
    {
        [HttpGet]
        [Route("ping")]
        public IActionResult Ping()
        {
            return Ok();
        }


        [HttpGet]
        [Route("values")]
        public string[] GetValues()
        {
            return new string[] { "item1", "item2" };
        }
    }
}