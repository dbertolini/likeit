using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeIT.Models
{
    public interface IImages
    {
        string[] getAllImages();
        string getRandomImage();
    }
}
