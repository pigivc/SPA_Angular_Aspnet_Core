using Contracts;
using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EfRepository
{
    public class MovieRepo : IMovieRepo
    {
        private SpaAppContext _context;

        public MovieRepo(SpaAppContext context)
        {
            _context = context;
        }

        //public SpaAppContext Context
        //{
        //    get
        //    {
        //        if (_context == null)
        //            return _context = SpaAppContext.CreateContext();
        //        else
        //            return _context;
        //    }
        //}

        public Movie GetMovie(int id)
        {
            return _context.Movies.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToArray();
        }

        public int CreateMovie(Movie model)
        {
            _context.Movies.Add(model);
            _context.SaveChanges();
            return model.Id;
        }

        public void UpdateMovie(Movie model)
        {
            _context.Entry<Movie>(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.First(p => p.Id == id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }
    }
}
