using MovieDb.Model;

namespace MovieDb.Data
{
    public interface IMovieDataProvider
    {
        Task<IEnumerable<Movie>?> GetMoviesAsync();
    }

    public class MovieDataProvider : IMovieDataProvider
    {
        public async Task<IEnumerable<Movie>?> GetMoviesAsync()
        {
            await Task.Delay(200);
            return new List<Movie>
            {
                new Movie
                {
                    Id = 1,
                    Title = "The Shawshank Redemption",
                    Genre = "Drama",
                    Year = 1994,
                    Director = "Frank Darabont",
                    Rating = "9.3",
                    Watched = true,
                    Owned = true
                },
                new Movie
                {
                    Id = 2,
                    Title = "The Godfather",
                    Genre = "Crime, Drama",
                    Year = 1972,
                    Director = "Francis Ford Coppola",
                    Rating = "9.2",
                    Watched = true,
                    Owned = false
                },
                new Movie
                {
                    Id = 3,
                    Title = "The Dark Knight",
                    Genre = "Action, Crime, Drama",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "9.0",
                    Watched = true,
                    Owned = true
                },
                new Movie
                {
                    Id = 4,
                    Title = "The Godfather: Part II",
                    Genre = "Crime, Drama",
                    Year = 1974,
                    Director = "Francis Ford Coppola",
                    Rating = "9.0",
                    Watched = true,
                    Owned = false
                },
                new Movie
                {
                    Id = 5,
                    Title = "12 Monkeys",
                    Genre = "Mystery, Sci-Fi, Thriller",
                    Year = 1995,
                    Director = "Terry Gilliam",
                    Rating = "8.0",
                    Watched = true,
                    Owned = true
                }
            };
        }
    }
}
