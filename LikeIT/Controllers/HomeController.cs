using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LikeIT.Models;

namespace LikeIT.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Likes");
            else
                return View();
        }

        public IActionResult Author()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
