using apkakosmiczna.Models; 

namespace apkakosmiczna.ViewModels;

public class SummaryWindowViewModel : ViewModelBase
{
    
    public FilmList FilmDetails { get; } 
    
    public SummaryWindowViewModel(FilmList data)
    {
        FilmDetails = data;
    }
}