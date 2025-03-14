﻿using MovieStore.Models.DTO;

namespace MovieStore.BL.Interfaces
{
    public interface IMovieService
    {
        List<Movie> GetMovies();

        void AddMovie(Movie movie);

        void DeleteMovie(string id);

        Movie? GetMoviesById(string id);
        IEnumerable<object> GetAllMovies();
    }
}