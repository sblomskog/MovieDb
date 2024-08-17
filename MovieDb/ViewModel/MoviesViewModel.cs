using System.Collections.ObjectModel;
using MovieDb.Command;
using MovieDb.Data;
using MovieDb.Model;

namespace MovieDb.ViewModel
{
    public class MoviesViewModel : ViewModelBase
    {
        private readonly IMovieDataProvider _movieDataProvider;
        private MovieItemViewModel? _selectedMovie;

        public MoviesViewModel(IMovieDataProvider movieDataProvider)
        {
            this._movieDataProvider = movieDataProvider;
            AddMovieCommand = new DelegateCommand(AddMovie);
            DeleteMovieCommand = new DelegateCommand(DeleteMovie, CanDelete);
        }

        public DelegateCommand AddMovieCommand { get; }

        public DelegateCommand DeleteMovieCommand { get; }

        public ObservableCollection<MovieItemViewModel> Movies { get; } = new();

        public MovieItemViewModel? SelectedMovie
        {
            get => _selectedMovie;
            set
            {
                _selectedMovie = value;
                RaisePropertyChanged();
                //RaisePropertyChanged(nameof(SelectedMovie)); // Alternative way to raise the event, but parameter not needed with CallerMemberName attribute
                DeleteMovieCommand.RaiseCanExecuteChanged();
            }
        }

        public async Task LoadMoviesAsync()
        {
            if (Movies.Any())
                return;

            var movies = await _movieDataProvider.GetMoviesAsync();
            if (movies is not null)
            {
                foreach (var movie in movies)
                {
                    Movies.Add(new MovieItemViewModel(movie));
                }
            }
        }

        private void AddMovie(object? parameter)
        {
            var movie = new Movie
            {
                Id = Movies.Count + 1,
                Title = "New Movie"
            };
            var viewModel = new MovieItemViewModel(movie);
            Movies.Add(viewModel);
            SelectedMovie = viewModel;
        }

        private void DeleteMovie(object? parameter)
        {
            if (SelectedMovie is not null)
            {
                Movies.Remove(SelectedMovie);
                SelectedMovie = null;
            }
        }

        private bool CanDelete(object? parameter) => SelectedMovie is not null;
    }
}