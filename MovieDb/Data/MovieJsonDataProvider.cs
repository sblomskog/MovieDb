using System.IO;
using MovieDb.Model;

namespace MovieDb.Data
{
    internal class MovieJsonDataProvider : IMovieDataProvider
    {
        public string JsonFilePath { get; set; }

        public Task<IEnumerable<Movie>?> GetMoviesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveMoviesAsync(IEnumerable<Movie> movies)
        {
            throw new NotImplementedException();
        }

        public T ReadFromJsonFile<T>() where T : class
        {
            if (!File.Exists(JsonFilePath))
            {
                return null;
            }

            var jsonData = File.ReadAllText(JsonFilePath);
            return System.Text.Json.JsonSerializer.Deserialize<T>(jsonData);
        }

        public void WriteToJsonFile<T>(T data) where T : class
        {
            var jsonData = System.Text.Json.JsonSerializer.Serialize(data, new System.Text.Json.JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(JsonFilePath, jsonData);
        }
    }
}
