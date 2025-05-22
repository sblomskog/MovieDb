using MovieDb.Data;
using MovieDb.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MovieDb.View
{
    /// <summary>
    /// Interaction logic for MovieList.xaml
    /// </summary>
    public partial class MovieList : UserControl
    {
        private MoviesViewModel _viewModel;
        public MovieList()
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
    }
}
