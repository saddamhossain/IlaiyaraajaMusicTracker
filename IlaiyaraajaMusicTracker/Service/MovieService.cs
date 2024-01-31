using IlaiyaraajaMusicTracker.Interface;
using IlaiyaraajaMusicTracker.Model;
using IlaiyaraajaMusicTracker.SeedData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IlaiyaraajaMusicTracker.Service
{
    public class MovieService : IMovie
    {
        public IList<Movie> GetMovies()
        {
            Seed seed = new Seed();
            var result = seed.movies.ToList();
            return result;
        }

        public IList<Movie> GetMovieByLanguage(string language)
        {
            Seed seed = new Seed();
            var result = seed.movies.Where(s => s.Language.ToLower() == language.ToLower()).ToList();
            return result;
        }

        public IList<Movie> GetMovieByDirector(string director)
        {
            Seed seed = new Seed();
            var result = seed.movies.Where(s => s.Director.ToLower() == director.ToLower()).ToList();
            return result;
        }

        public IList<Movie> GetMovieByYear(int year)
        {
            Seed seed = new Seed();
            var result = seed.movies.Where(s => s.Year == year).ToList();
            return result;
        }

        public IList<Song> GetSongsByFilmId(int filmId)
        {
            Seed seed = new Seed();
            List<Song> song = new List<Song>();

            var result = seed.movies.Where(s => s.FilmID == filmId).FirstOrDefault();
            song = result.Songs.ToList();
            return song;
        }

        public Movie GetMovieDetailsByFilmId(int filmId)
        {
            Seed seed = new Seed();
            var result = seed.movies.Where(s => s.FilmID == filmId).FirstOrDefault();
            return result;
        }

        #region IDisposable Support
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
