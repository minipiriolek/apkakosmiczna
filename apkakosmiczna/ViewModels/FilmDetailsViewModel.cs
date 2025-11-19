namespace apkakosmiczna.ViewModels;

using ReactiveUI;
using apkakosmiczna.ViewModels; 
public class FilmDetailsViewModel : ViewModelBase
{
    public FilmList Film { get; } 
    
    public FilmDetailsViewModel(FilmList film)
    {
        Film = film;
    }
}