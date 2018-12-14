// using System;
// using System.Linq;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.Logging;
// using Microsoft.AspNetCore.Mvc.Formatters.Json;
// using aspnetAndReact.Models;
// using Microsoft.AspNetCore.JsonPatch;

// namespace aspnetAndReact
// {

//     [Route("api/[controller]")]
//     public class PostController : Controller
//     {

//         ILogger<PostController> _logger;

//         public PostController(ILogger<PostController> logger)
//         {
//             _logger = logger;
//         }


//         [HttpGet("[action]/{goalId}")]
//         public IActionResult GetGoalPosts(int goalId, int ID)
//         {
//             try
//             {
//                 return Ok();
//             }
//             catch (Exception)
//             {
//                 _logger.LogError("Failed to execute GET");
//                 return BadRequest();
//             }
//         }

//         [HttpGet("{goalId}/[action]/{postId}")]
//         public IActionResult GetPost(int goalId, int postId)
//         {
//             try
//             {
//                 var goal = GoalsMockData.Current.Goals.First(g => g.ID == goalId);


//                 var postToReturn = goal.Posts.First(p => p.ID == postId);

//                 return Ok(postToReturn);
//             }
//             catch (Exception)
//             {
//                 return NotFound();
//             }
//         }

//         [HttpPost("{goalId}/[action]")]
//         public IActionResult CreatePost(int goalId, [FromBody] PostDTO model)
//         {
//             if (model == null)
//             {
//                 return BadRequest("No Data has been passed");
//             }

//             var goal = GoalsMockData.Current.Goals.FirstOrDefault(g => g.ID == goalId);

//             if (goal == null) return NotFound("Associated Goal could not be found. GoalID :" + goalId.ToString());

//             try
//             {
//                 //DRGG: DEV only
//                 var maxId = GoalsMockData.Current.Goals.SelectMany(g => g.Posts).Max(p => p.ID);
//                 var PostToCreate = new PostDTO()
//                 {
//                     Id = ++maxId,
//                     GoaldID = goalId,
//                     Header = model.Header,
//                     Content = model.Content,
//                     PictureID = model.PictureID,
//                     DateCreated = DateTime.UtcNow


//                 };

//                 goal.Posts.Add(PostToCreate);

//                 return Created("GetPost"
//                , PostToCreate);

//             }
//             catch (Exception)
//             {
//                 _logger.LogError("Failed to execute POST");
//                 return BadRequest();
//             }
//         }

//         [HttpPatch("{goalId}/[action]/{postId}")]
//         public IActionResult PatchPost(int goalId, int postId, [FromBody] JsonPatchDocument<PostCreateDTO> patchDoc)
//         {
//             if (patchDoc == null)
//             {
//                 return BadRequest();
//             }

//             var goal = GoalsMockData.Current.Goals.FirstOrDefault(g => g.ID == goalId);
//             if (goal == null)
//             {
//                 return NotFound();
//             }

//             var post = goal.Posts.FirstOrDefault(p => p.ID == postId);
//             if (post == null)
//             {
//                 return NotFound();
//             }


//             var postToPatch = new PostCreateDTO()
//             {
//                 Header = post.Header,
//                 Content = post.Content,
//                 PictureID = post.PictureID
//             };
//             patchDoc.ApplyTo(postToPatch, ModelState);

//             if (!ModelState.IsValid)
//             {
//                 return BadRequest(ModelState);
//             }

//             post.Header = postToPatch.Header;
//             post.Content = postToPatch.Content;
//             post.PictureID = postToPatch.PictureID;

//             return NoContent();



//         }




//         [HttpPut("{goalId}/[action]/{postId}")]
//         public IActionResult PutPost(int goalId, int postId, [FromBody] PostCreateDTO model)
//         {
//             try
//             {
//                 var postToEdit = GoalsMockData.Current.Goals.SelectMany(g => g.Posts).FirstOrDefault(p => p.ID == postId);

//                 postToEdit.Header = model.Header;
//                 postToEdit.Content = model.Content;
//                 postToEdit.PictureID = model.PictureID;

//                 var goal = GoalsMockData.Current.Goals.FirstOrDefault(g => g.ID == goalId);
//                 return Ok();
//             }
//             catch (Exception)
//             {
//                 _logger.LogError("Failed to execute PUT");
//                 return BadRequest();
//             }
//         }

//         [HttpDelete("{goalId}/[action]/{postId}")]
//         public IActionResult Delete(int goalId, int postId)
//         {
//             try
//             {
//                 var goal = GoalsMockData.Current.Goals.FirstOrDefault(g => g.ID == goalId);
//                 if (goal == null)
//                 {
//                     return NotFound();
//                 }
//                 var postToRemove = goal.Posts.FirstOrDefault(p => p.ID == postId);
//                 if (postToRemove == null)
//                 {
//                     return NotFound();
//                 }

//                 goal.Posts.Remove(postToRemove);

//                 return NoContent();
//             }
//             catch (Exception)
//             {
//                 _logger.LogError("Failed to execute DELETE");
//                 return BadRequest();
//             }
//         }
//     }
// }