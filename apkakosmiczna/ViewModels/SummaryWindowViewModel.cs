using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using apkakosmiczna.Models;
using ReactiveUI;

namespace apkakosmiczna.ViewModels;

public class SummaryWindowViewModel : ViewModelBase
{
    
    public FilmList FilmDetails { get; } 
    
    public string MainCharactersString => 
        string.Join(", ", FilmDetails.MainCharacters ?? new List<string>());
    
    public Interaction<List<string>, Unit> ShowCharactersWindow { get; } 
    public ReactiveCommand<Unit, Unit> CharactersButton { get; }
    
    
    
    
    
    public SummaryWindowViewModel(FilmList data)
    {
        FilmDetails = data;

        ShowCharactersWindow = new Interaction<List<string>, Unit>();

        CharactersButton = ReactiveCommand.CreateFromTask(async () =>
        {
            if (FilmDetails.MainCharacters != null)
            {
                await ShowCharactersWindow.Handle(FilmDetails.MainCharacters);
            }
        });
    }
    
    

    
}