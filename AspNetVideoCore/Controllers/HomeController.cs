﻿using Microsoft.AspNetCore.Mvc;
using AspNetVideoCore.Services;
using System.Linq;
using System;
using AspNetVideoCore.Models;
using AspNetVideoCore.ViewModels;

namespace AspNetVideoCore.Controllers
{
    public class HomeController : Controller
    {
        private IVideoData _videos;

        public HomeController(IVideoData videos)
        {
            _videos = videos;
        }

        public ViewResult Index()
        {
            var model = _videos.GetAll().Select(video =>
                new VideoViewModel
                {
                    Id = video.Id,
                    Title = video.Title,
                    Genre = Enum.GetName(typeof(Genres), video.GenreId)
                });

            return View(model);
        }
    }
}
