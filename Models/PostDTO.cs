
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspnetAndReact.Models
{
    public class PostDTO   
    {
        public int ID { get; set; }
        public int GoaldID { get; set; }    
        public string Header { get; set; }
        public string Content { get; set; }
        
        //DRGG: To be replaced by image or reference type
        public List<int?> PictureID { get; set; }
        public DateTime DateCreated { get; set; }
        
    }
}