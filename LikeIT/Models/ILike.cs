using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeIT.Models
{
    public interface ILike
    {
        void doLike(string user, string image);
        void doDislike(string user, string image);

    }
}
