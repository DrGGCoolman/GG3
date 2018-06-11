using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace aspnetAndReact.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        [HttpGet("[action]")]
        public JsonResult GetGoals()
        {
            return new JsonResult(GoalsMockData.Current.Goals);
        }
        
        public IActionResult Index()
        {
            try
            {

                return Ok("Index home got called");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}