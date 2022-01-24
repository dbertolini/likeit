using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LikeIT.Data;
using LikeIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace LikeIT.Controllers
{
    public class HistoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HistoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Like like = new Like();
            like.UserID = User.Identity.Name;

            if (User.Identity.IsAuthenticated)
                return View(_context.Like.Where( a => a.UserID==User.Identity.Name).ToList());
            else
                return RedirectToAction("Index", "Home");                
        }
    }
}