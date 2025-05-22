using MovieDb.Model;

namespace MovieDb.Data
{
    public interface IMovieDataProvider
    {
        Task<IEnumerable<Movie>?> GetMoviesAsync();

        Task<bool> SaveMoviesAsync(IEnumerable<Movie> movies);
    }
}
