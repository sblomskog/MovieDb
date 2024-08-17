using MovieDb.Model;

namespace MovieDb.ViewModel
{
    public class MovieItemViewModel : ViewModelBase
    {
        private readonly Movie _model;
        public MovieItemViewModel(Movie model)
        {
            _model = model;
        }

        public int Id => _model.Id;

        public string? Title
        {
            get => _model.Title;
            set
            {
                _model.Title = value;
                RaisePropertyChanged();
            }
        }

        public string? Genre
        {
            get => _model.Genre;
            set
            {
                _model.Genre = value;
                RaisePropertyChanged();
            }
        }

        public int? Year
        {
            get => _model.Year;
            set
            {
                _model.Year = value;
                RaisePropertyChanged();
            }
        }

        public string? Director
        {
            get => _model.Director;
            set
            {
                _model.Director = value;
                RaisePropertyChanged();
            }
        }

        public string? Rating
        {
            get => _model.Rating;
            set
            {
                _model.Rating = value;
                RaisePropertyChanged();
            }
        }

        public bool Watched
        {
            get => _model.Watched;
            set
            {
                _model.Watched = value;
                RaisePropertyChanged();
            }
        }

        public bool Own
        {
            get => _model.Owned;
            set
            {
                _model.Owned = value;
                RaisePropertyChanged();
            }
        }
    }
}
