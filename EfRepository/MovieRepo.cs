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
        private IRepository<Movie> _movieRepo;

        public MovieRepo(IRepository<Movie> movieRepo)
        {
            _movieRepo = movieRepo;
        }

        public Movie GetMovie(long id) => _movieRepo.Get(id);

        public IEnumerable<Movie> GetMovies() => _movieRepo.GetAll();

        public long CreateMovie(Movie model)
        {
            _movieRepo.Insert(model);
            _movieRepo.SaveChanges();
            return model.Id;
        }

        public void UpdateMovie(Movie model)
        {
            _movieRepo.Update(model);
        }

        public void DeleteMovie(long id) => _movieRepo.Delete(_movieRepo.Get(id));

    }
}
