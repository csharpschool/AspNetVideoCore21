using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetVideoCore.Models;

namespace AspNetVideoCore.Services
{
    public interface IVideoData
    {
        IEnumerable<Video> GetAll();
    }
}
