
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace aspnetAndReact.Data
{
    public class PostCreateDTO
    {

        public int Id { get; set; }

        [MaxLength(50)]
        public string Header { get; set; }
        [Required]
        [MaxLength(200)]
        public string Content { get; set; }

        //DRGG: To be replaced by binary or reference type
        public List<int?> PictureID { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

    }
}