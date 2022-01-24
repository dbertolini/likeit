using LikeIT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeIT.Models
{
    public class Like
    {
        public int LikeId { get; set; }
        public string Picture { get; set; }
        public bool Interest { get; set; }
        public string UserID { get; set; } 
        public DateTime DateAction { get; set; }
    }
}
