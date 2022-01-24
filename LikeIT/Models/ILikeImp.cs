using LikeIT.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeIT.Models
{
    public class ILikeImp : ILike
    {
        private readonly ApplicationDbContext _context;

        public ILikeImp(ApplicationDbContext context)
        {
            _context = context;
        }

        public void doDislike(string user, string image)
        {
            Like like = new Like();
            like.UserID = user;
            like.Picture = image;
            like.Interest = false;
            like.DateAction = DateTime.Now;

            _context.Add(like);
            _context.SaveChanges();
        }

        public void doLike(string user, string image)
        {
            Like like = new Like();
            like.UserID = user;
            like.Picture = image;
            like.Interest = true;
            like.DateAction = DateTime.Now;

            _context.Add(like);
            _context.SaveChanges();
        }
    }
}
