using Entities;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IMovieRepo
    {
        Movie GetMovie(long id);

        IEnumerable<Movie> GetMovies();

        long CreateMovie(Movie model);

        void UpdateMovie(Movie model);

        void DeleteMovie(long id);
    }
}
