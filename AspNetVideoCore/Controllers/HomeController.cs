using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetVideoCore.Models;

namespace AspNetVideoCore.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            var model = new List<Video>
            {
                new Video { Id = 1, Title = "Shreck" },
                new Video { Id = 2, Title = "Despicable Me" },
                new Video { Id = 3, Title = "Megamind" }
            };

            return View(model);
        }
    }
}
