using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace apkakosmiczna.ViewModels;

public class MainWindowViewModel : ViewModelBase
{


    public ObservableCollection<FilmList> Films { get; } = new()
    {
        new FilmList
        {
            Title = "Alien",
            PolishTitle = "Obcy – ósmy pasażer Nostromo",
            Year = 1979,
            Director = "Ridley Scott",
            Genre = "Sci-Fi / Horror",
            Lenght = 117,
            Rating = 8.5,
            MainCharacters = new List<string> { "Ellen Ripley", "Dallas", "Ash", "Lambert", "Kane" },
            SpaceShip = "USCSS Nostromo",
            Description = "Załoga statku handlowego Nostromo odbiera sygnał z nieznanej planety. " +
                          "Po lądowaniu odkrywają obcą formę życia, która zaczyna eliminować członków załogi jeden po drugim.",
            FunFact =
                "Scena z „wyskakującym potworem” z klatki piersiowej aktora była niespodzianką dla obsady – ich reakcje są autentyczne."
        },

        new FilmList
        {
            Title = "Aliens",
            PolishTitle = "Obcy – decydujące starcie",
            Year = 1986,
            Director = "James Cameron",
            Genre = "Sci-Fi / Akcja / Horror",
            Lenght = 137,
            Rating = 8.4,
            MainCharacters = new List<string> { "Ellen Ripley", "Hicks", "Newt", "Bishop", "Vasquez" },
            SpaceShip = "USS Sulaco",
            Description =
                "Ripley, jedyna ocalała z wcześniejszego ataku obcego, wraca z oddziałem kolonialnych marines " +
                "na księżyc LV-426, by zbadać utratę kontaktu z kolonią. Wkrótce stają oko w oko z armią obcych.",
            FunFact =
                "James Cameron napisał scenariusz podczas lotu do Londynu – tytuł w liczbie mnogiej symbolizuje, że tym razem potworów będzie więcej."
        },

        new FilmList
        {
            Title = "Alien³",
            PolishTitle = "Obcy³",
            Year = 1992,
            Director = "David Fincher",
            Genre = "Sci-Fi / Horror",
            Lenght = 114,
            Rating = 6.5,
            MainCharacters = new List<string> { "Ellen Ripley", "Dillon", "Clemens", "Morse", "Andrews" },
            SpaceShip = "E.E.V. z USS Sulaco",
            Description = "Po katastrofie statku Sulaco Ripley trafia na więzienną planetę Fiorina 161, " +
                          "gdzie wkrótce pojawia się obcy. Pozbawiona broni i wsparcia, musi walczyć o życie " +
                          "wśród skazańców i odkrywa, że nosi w sobie embrion królowej obcych.",
            FunFact =
                "David Fincher zadebiutował tym filmem jako reżyser, jednak miał ograniczoną kontrolę twórczą – produkcja była pełna konfliktów."
        },

        new FilmList
        {
            Title = "Alien: Resurrection",
            PolishTitle = "Obcy: Przebudzenie",
            Year = 1997,
            Director = "Jean-Pierre Jeunet",
            Genre = "Sci-Fi / Horror",
            Lenght = 109,
            Rating = 6.2,
            MainCharacters = new List<string> { "Ellen Ripley (klon)", "Call", "Johner", "Christie", "Dr. Gediman" },
            SpaceShip = "USM Auriga",
            Description =
                "Dwieście lat po śmierci Ripley naukowcy klonują ją, by wydobyć królową obcych z jej ciała. " +
                "Klonowana Ripley zyskuje niezwykłe zdolności i wraz z grupą kosmicznych najemników " +
                "musi zapobiec katastrofie, gdy obcy wydostają się na wolność.",
            FunFact =
                "Postać androidki Call gra Winona Ryder, a film miał być początkiem nowej trylogii, która jednak nigdy nie powstała."
        },

        new FilmList
        {
            Title = "Prometheus",
            PolishTitle = "Prometeusz",
            Year = 2012,
            Director = "Ridley Scott",
            Genre = "Sci-Fi / Thriller",
            Lenght = 124,
            Rating = 7.0,
            MainCharacters = new List<string> { "Elizabeth Shaw", "David", "Charlie Holloway", "Meredith Vickers" },
            SpaceShip = "USCSS Prometheus",
            Description = "Ekspedycja naukowa wyrusza na odległą planetę, by odkryć pochodzenie ludzkości. " +
                          "Załoga Prometeusza odkrywa ruiny cywilizacji Inżynierów oraz coś, co nigdy nie powinno zostać obudzone.",
            FunFact =
                "Ridley Scott planował, aby film był zarówno prequelem „Obcego”, jak i samodzielną opowieścią o powstaniu życia i człowieka."
        },

        new FilmList
        {
            Title = "Alien: Covenant",
            PolishTitle = "Obcy: Przymierze",
            Year = 2017,
            Director = "Ridley Scott",
            Genre = "Sci-Fi / Horror",
            Lenght = 122,
            Rating = 6.4,
            MainCharacters = new List<string> { "Daniels", "David", "Walter", "Oram", "Tennessee" },
            SpaceShip = "USCSS Covenant",
            Description = "Załoga statku kolonizacyjnego Covenant odkrywa nieznaną planetę, idealną do osiedlenia. " +
                          "Na miejscu natrafiają na Davida – syntetyka ocalałego z Prometeusza – oraz nowe formy obcych stworzeń.",
            FunFact =
                "Film pierwotnie miał nosić tytuł „Paradise Lost”; Scott planował jeszcze jedną część łączącą fabułę z oryginalnym „Obcym”."
        }
    };

    private FilmList _selectedFilm;
    
    [Reactive]
    public string NewItem { get; set; } = string.Empty;

    [Reactive]
    public string? SelectedItem { get; set; }
    


}