using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IlaiyaraajaMusicTracker.Model
{
    public class Movie
    {
        public int FilmID { set; get; }
        public string Language { set; get; }
        public string Film { set; get; }
        public string Director { set; get; }
        public int Year { set; get; }
        public List<Song> Songs { set; get; }
    }
}
