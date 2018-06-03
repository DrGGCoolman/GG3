using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace NamespaceName
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
       [HttpGet]
       public IActionResult Get()
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
        public JsonResult GetGoals()
        {
            return new JsonResult(new List<object>()
            {
              new {id=1, Name = "First Goal"},
              new  {id=2, Name="Second Goal"}
});
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