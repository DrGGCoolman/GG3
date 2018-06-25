using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Formatters.Json;
using aspnetAndReact.Models;

namespace aspnetAndReact
{

    [Route("api/[controller]")]
    public class PostController : Controller
    {

        ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }


        [HttpGet("[action]/{goalId}")]
        public IActionResult GetGoalPosts(int goalId, int ID)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute GET");
                return BadRequest();
            }
        }

        [HttpGet("[action]/{id}")]
        public IActionResult GetPost(int ID)
        {
            try
            {
                var postToReturn = GoalsMockData.Current.Goals.SelectMany(g => g.Posts).FirstOrDefault(p => p.ID == ID);
                if (postToReturn == null) return NotFound("Post not Found");
                return Ok(postToReturn);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("{goalId}/[action]")]
        public IActionResult CreatePost(int goalId, [FromBody] PostCreateDTO model)
        {
            if (model == null)
            {
                return BadRequest("No Data has been passed");
            }

            var goal = GoalsMockData.Current.Goals.FirstOrDefault(g => g.ID == goalId);

            if (goal == null) return NotFound("Associated Goal could not be found. GoalID :" + goalId.ToString());

            try
            {
                //DRGG: DEV only
                var maxId = GoalsMockData.Current.Goals.SelectMany(g => g.Posts).Max(p => p.ID);
                var PostToCreate = new PostDTO()
                {
                    ID = ++maxId,
                    GoaldID = goalId,
                    Header = model.Header,
                    Content = model.Content,
                    PictureID = model.PictureID,
                    DateCreated = DateTime.UtcNow


                };
                goal.Posts.Add(PostToCreate);

                return Created("GetPost"
               , PostToCreate);
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute POST");
                return BadRequest();
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] PostCreateDTO model)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute PUT");
                return BadRequest();
            }
        }

        [HttpDelete]
        public IActionResult Delete(int pId)
        {
            try
            {
                return Ok();
            }
            catch (Exception)
            {
                _logger.LogError("Failed to execute DELETE");
                return BadRequest();
            }
        }
    }
}