using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aspnetAndReact.Models;

namespace aspnetAndReact.Controllers
{

    [Route("api/[controller]")]
    public class GoalController : Controller
    {


        ILogger<GoalController> _logger;

        public GoalController(ILogger<GoalController> logger)
        {
            _logger = logger;
        }

        [HttpGet("[action]")]
        public IActionResult GetGoals()
        {
            try
            {
                return Ok(GoalsMockData.Current.Goals);
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
                return Ok(GoalsMockData.Current.Goals.FirstOrDefault(x => x.ID == id));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        //     [HttpPost]
        //     public IActionResult Post([FromBody] GoalDTO model)
        //     {
        //       try
        //       {
        //         return Created("", null);
        //       }
        //       catch (Exception)
        //       {
        //         _logger.LogError("Failed to execute POST");
        //         return BadRequest();
        //       }
        //     }

        //     [HttpPut]
        //     public IActionResult Put([FromBody] GoalDTO model)
        //     {
        //       try
        //       {
        //         return Ok();
        //       }
        //       catch (Exception)
        //       {
        //         _logger.LogError("Failed to execute PUT");
        //         return BadRequest();
        //       }
        //     }

        //     [HttpDelete]
        //     public IActionResult Delete(int id)
        //     {
        //       try
        //       {
        //         return Ok();
        //       }
        //       catch (Exception)
        //       {
        //         _logger.LogError("Failed to execute DELETE");
        //         return BadRequest();
        //       }
        //     }
    }
}