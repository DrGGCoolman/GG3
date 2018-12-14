using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore;
using aspnetAndReact.Models;
using aspnetAndReact.Data;
using Newtonsoft.Json;

using Microsoft.EntityFrameworkCore;

namespace aspnetAndReact.Controllers
{

    [Route("api/[controller]")]
    public class GoalController : Controller
    {
        private readonly ILogger<GoalController> _logger;
        private readonly GGContext _ggContext;




        public GoalController(ILogger<GoalController> logger, GGContext ggContext)
        {
            _logger = logger;
            _ggContext = ggContext;
        }

        [HttpGet("[action]")]
        public IActionResult GetGoals()
        {
            try
            {
                return Ok(JsonConvert.SerializeObject(_ggContext.Goals));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetGoal(int id)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }


    }
}