using Avalonia.Controls;
using apkakosmiczna.ViewModels;

namespace apkakosmiczna.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void FilmsList_SelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (FilmsList.SelectedItem is Film selectedFilm)
        {
            var details = new DetailedScreen();
            details.DataContext = new DetailedScreenViewModel(selectedFilm);
            details.Show();
        }
    }
}
