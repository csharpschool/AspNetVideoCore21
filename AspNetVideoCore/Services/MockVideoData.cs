﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetVideoCore.Entities;

namespace AspNetVideoCore.Services
{
    public class MockVideoData : IVideoData
    {
        private IEnumerable<Video> _videos;

        public MockVideoData()
        {
            _videos = new List<Video>
            {
                new Video { Id = 1, GenreId = 2, Title = "Shreck" },
                new Video { Id = 2, GenreId = 2, Title = "Despicable Me" },
                new Video { Id = 3, GenreId = 2, Title = "Megamind" }
            };
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }
    }
}