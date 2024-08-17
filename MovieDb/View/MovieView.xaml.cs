using System.Windows;
using System.Windows.Controls;
using MovieDb.Data;
using MovieDb.ViewModel;

namespace MovieDb.View
{
    /// <summary>
    /// Interaction logic for MovieView.xaml
    /// </summary>
    public partial class MovieView : UserControl
    {
        private MoviesViewModel _viewModel;

        public MovieView()
        {
            InitializeComponent();
            _viewModel = new MoviesViewModel(new MovieDataProvider());
            DataContext = _viewModel;
            Loaded += OnLoaded;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
           await _viewModel.LoadMoviesAsync();
        }

        private void BtnDeleteMovie_OnClick(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
