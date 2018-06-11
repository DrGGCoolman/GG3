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
        public IActionResult GetGoals()
        {
            try
            {
                return new JsonResult(GoalsMockData.Current.Goals);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetGoal(int id)
        {
            try
            {
                return new JsonResult(GoalsMockData.Current.Goals[id]);
            }
            catch (Exception)
            {
                return BadRequest();
            }
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