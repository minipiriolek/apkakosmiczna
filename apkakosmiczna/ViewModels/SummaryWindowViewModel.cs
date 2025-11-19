using apkakosmiczna.Models; 

namespace apkakosmiczna.ViewModels;

public class SummaryWindowViewModel : ViewModelBase
{
    
    public FilmList FilmDetails { get; } 
    
    public string MainCharactersString => 
        string.Join(", ", FilmDetails.MainCharacters);
    
    public SummaryWindowViewModel(FilmList data)
    {
        FilmDetails = data;
    }
}