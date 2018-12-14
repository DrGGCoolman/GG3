
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace aspnetAndReact.Data
{
    public class PostDTO
    {

        public int Id { get; set; }

        [MaxLength(50)]
        public string Header { get; set; }
        [Required]
        [MaxLength(200)]
        public string Content { get; set; }
        public DateTime DateCreated { get; set; }

    }
}