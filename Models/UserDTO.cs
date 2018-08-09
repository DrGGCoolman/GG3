
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetAndReact.Models
{
    public class UserDTO
    {
        public int ID { get; set; }
        public string Username { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateChanged { get; set; }
        public DateTime? DateDeleted { get; set; }

    }
}