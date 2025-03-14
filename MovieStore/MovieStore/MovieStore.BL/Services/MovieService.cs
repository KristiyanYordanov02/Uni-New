﻿using MovieStore.BL.Interfaces;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;

namespace MovieStore.BL.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        public void AddMovie(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        public Movie? GetById(int id)
        {
            return _movieRepository.GetMovieById(id);
        }

        public object GetDetailedMovies()
        {
            throw new NotImplementedException();
        }

        public List<Movie> GetMovies()
        {
            throw new NotImplementedException();
        }

        public void DeleteMovie(string id)
        {
            throw new NotImplementedException();
        }

        public Movie? GetMoviesById(string id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<object> IMovieService.GetAllMovies()
        {
            throw new NotImplementedException();
        }
    }
}