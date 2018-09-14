using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetVideoCore.Models;

namespace AspNetVideoCore.ViewModels
{
    public class VideoEditViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genres Genre { get; set; }
    }
}
