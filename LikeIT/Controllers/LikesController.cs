using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LikeIT.Models;
using Microsoft.AspNetCore.Mvc;

namespace LikeIT.Controllers
{
    public class LikesController : Controller
    {
        public IImages Images { get; set; }
        public ILike Like { get; set; }
        public static string strImage;

        public LikesController(IImages images, ILike like)
        {
            this.Images = images;
            this.Like = like;

        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                strImage = this.Images.getRandomImage();
                return View((object)strImage);
            }
            else
                return RedirectToAction("Index", "Home");
        }

        public IActionResult doLike()
        {
            try { 
                this.Like.doLike(User.Identity.Name, strImage);
                return RedirectToAction("Index", "Likes");
            }
            catch(Exception ex)
            {
                return RedirectToAction("Error", "Shared");
            }
        }

        public IActionResult doDislike(string user, string image)
        {
            try { 
                this.Like.doDislike(User.Identity.Name, strImage);
                return RedirectToAction("Index", "Likes");
            }
            catch(Exception ex)
            {
                return RedirectToAction("Error","Shared");
            }
        }
    }
}