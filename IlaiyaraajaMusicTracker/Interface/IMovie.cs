using IlaiyaraajaMusicTracker.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IlaiyaraajaMusicTracker.Interface
{
    public interface IMovie : IDisposable
    {
        IList<Movie> GetMovies();
        IList<Movie> GetMovieByLanguage(string language);
        IList<Movie> GetMovieByDirector(string director);
        IList<Movie> GetMovieByYear(int year);
        IList<Song> GetSongsByFilmId(int filmId);
        Movie GetMovieDetailsByFilmId(int filmId);
    }
}
