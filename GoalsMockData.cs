using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspnetAndReact.Models;

namespace aspnetAndReact
{
    public class GoalsMockData
    {
        public static GoalsMockData Current { get; } = new GoalsMockData();
        public List<GoalDTO> Goals { get; set; }
        public GoalsMockData()
        {
            Goals = new List<GoalDTO> {
                new GoalDTO
                {
                    ID = 1,
                    Title = "-5kg in 6 weeks",
                    Desc = "losing losing 5kg in 6 weeks, and keeping it low",
                    DateCreated = DateTime.Now


                },
                new GoalDTO
                {
                    ID = 2,
                    Title = "freemind",
                    Desc = "freeing my mind by daily meditation",
                    DateCreated = DateTime.Now


                },
                new GoalDTO
                {
                    ID = 3,
                    Title = "restore bmw E36",
                    Desc = "completly overhaul my E36",
                    DateCreated = DateTime.Now


                }

            };
        }
    }
}