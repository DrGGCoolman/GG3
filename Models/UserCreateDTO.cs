
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetAndReact.Models
{
    public class UserCreateDTO
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public DateTime DateCreated
        {
            get
            {
                return DateCreated;
            }
            set
            {
                DateCreated = DateTime.Now;
            }
        }

        public DateTime DateChanged
        {
            get
            {
                return DateChanged;
            }
            set
            {
                DateChanged = DateTime.Now;
            }
        }
    }

}
