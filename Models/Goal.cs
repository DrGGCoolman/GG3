
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetAndReact.Models
{
    public class Goal
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateAchieved { get; set; }
        public List<Post> Posts { get; set; }
    }
}