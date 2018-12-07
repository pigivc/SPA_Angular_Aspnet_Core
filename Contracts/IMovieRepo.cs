using Entities;
using System;
using System.Collections.Generic;

namespace Contracts
{
    public interface IMovieRepo
    {
        Movie GetMovie(int id);

        IEnumerable<Movie> GetMovies();

        int CreateMovie(Movie model);

        void UpdateMovie(Movie model);

        void DeleteMovie(int id);
    }
}
