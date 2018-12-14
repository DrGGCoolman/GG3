// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using aspnetAndReact.Data;

// namespace aspnetAndReact
// {
//     public class GoalsMockData
//     {
//         public static GoalsMockData Current { get; } = new GoalsMockData();
//         public List<GoalDTO> Goals { get; set; }
//         public GoalsMockData()
//         {
//             Goals = new List<GoalDTO> {
//                 new GoalDTO
//                 {
//                     ID = 1,
//                     Title = "-5kg in 6 weeks",
//                     Desc = " losing 5kg in 6 weeks, and keeping it low",
//                     Posts = new List<PostDTO>{
//                         new PostDTO{
//                             ID = 1,
//                             Header= "My First Steps",
//                             PictureID= null,
//                             GoaldID = 1,
//                             Content = "i was jogging today",
//                             DateCreated = DateTime.Now,



//                         },

//                     },
//                     DateCreated = DateTime.Now


//                 },
//                 new GoalDTO
//                 {
//                     ID = 2,
//                     Title = "freemind",
//                     Desc = "freeing my mind by daily meditation",
//                     DateCreated = DateTime.Now,
//                        Posts = new List<PostDTO>{
//                         new PostDTO{
//                             ID = 3,
//                             Header= "Inner Peace",
//                             PictureID= null,
//                             GoaldID = 2,
//                             Content = "i was meditating today",
//                             DateCreated = DateTime.Now,



//                         },

//                        }

//                 },
//                 new GoalDTO
//                 {
//                     ID = 3,
//                     Title = "restore bmw E36",
//                     Desc = "completly overhaul my E36",
//                     DateCreated = DateTime.Now,
//                        Posts = new List<PostDTO>{
//                         new PostDTO{
//                             ID = 2,
//                             Header= "Inner Peace",
//                             PictureID= null,
//                             GoaldID = 3,
//                             Content = "i was meditating today",
//                             DateCreated = DateTime.Now,



//                         },

//                        }


//                 }

//             };
//         }
//     }
// }