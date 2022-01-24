using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LikeIT.Models
{
    public class IImagesImp : IImages
    {
        // Get all images in the folder
        public string[] getAllImages()
        {
            // The path where are the images is wwwroot/images
            string[] images = Directory.GetFiles("wwwroot/images", "*.jpg");
            return images;
        }

        // Get just one random image from the folder
        public string getRandomImage()
        {
            // Get all images in folder
            string[] images = this.getAllImages();

            // Select one random
            Random r = new Random();
            int index = r.Next(0, images.Count());

            return images[index].ToString().Split('\\')[1];
        }
    }
}
