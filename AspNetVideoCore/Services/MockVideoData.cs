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
                new Video { Id = 1, Genre = Models.Genres.Animated, Title = "Shreck" },
                new Video { Id = 2, Genre = Models.Genres.Animated, Title = "Despicable Me" },
                new Video { Id = 3, Genre = Models.Genres.Animated, Title = "Megamind" }
            };
        }

        public IEnumerable<Video> GetAll()
        {
            return _videos;
        }

        public Video Get(int id)
        {
            return _videos.FirstOrDefault(v => v.Id.Equals(id));
        }

    }
}
