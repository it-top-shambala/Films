using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using Films.Lib;

namespace Films.App
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Doc> Films { get; set; }
        private FilmsInfo _films;
        public MainWindow()
        {
            Films = new ObservableCollection<Doc>();
            InitializeComponent();
        }

        private void ButtonSearch_OnClick(object sender, RoutedEventArgs e)
        {
            var search = InputSearch.Text;
            _films = KinopoiskApi.SearchFilms(search);
            Films = new ObservableCollection<Doc>(_films.docs);
            ListFilm.ItemsSource = Films;
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}