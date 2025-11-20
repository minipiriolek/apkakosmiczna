using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using apkakosmiczna.Models;
using DynamicData;
using ReactiveUI;

namespace apkakosmiczna.ViewModels;

public class CharactersWindowViewModel : ViewModelBase
{
    public ObservableCollection<CharactersList> Characters { get; } = new()
    {
        new CharactersList
        {
            Name = "Ellen Louise Ripley",
            FilmName = "Alien (1979), Aliens (1986), Alien³ (1992), Alien: Resurrection (1997)",
            Role = "Oficer porządkowy / specjalistka ds. bezpieczeństwa",
            ActorName = "Sigourney Weaver",
            Species = "Człowiek",
            BirthYear = 2092
        },
        new CharactersList
        {
            Name = "Arthur Koblenz Dallas",
            FilmName = "Alien (1979)",
            Role = "Kapitan USCSS Nostromo",
            ActorName = "Tom Skerritt",
            Species = "Człowiek",
            BirthYear = 2071
        },
        new CharactersList
        {
            Name = "Ash",
            FilmName = "Alien (1979)",
            Role = "Oficer naukowy",
            ActorName = "Ian Holm",
            Species = "Android (Hyperdyne Systems 120-A/2)",
            BirthYear = null
        },
        new CharactersList
        {
            Name = "Bishop",
            FilmName = "Aliens (1986), Alien³ (1992)",
            Role = "Oficer naukowy, android kolonialnych marines",
            ActorName = "Lance Henriksen",
            Species = "Android (Hyperdyne 341-B)",
            BirthYear = null
        },
        new CharactersList
        {
            Name = "Jenette Vasquez",
            FilmName = "Aliens (1986)",
            Role = "Strzelec kolonialnych marines",
            ActorName = "Jenette Goldstein",
            Species = "Człowiek",
            BirthYear = 2124
        },
        new CharactersList
        {
            Name = "Rebecca \"Newt\" Jorden",
            FilmName = "Aliens (1986)",
            Role = "Jedyna ocalała z kolonii Hadley’s Hope",
            ActorName = "Carrie Henn",
            Species = "Człowiek",
            BirthYear = 2172
        },
        new CharactersList
        {
            Name = "The Queen Alien",
            FilmName = "Aliens (1986), Alien: Resurrection (1997)",
            Role = "Królowa ksenomorfów",
            ActorName = "Efekty praktyczne / animatronics",
            Species = "Ksenomorf",
            BirthYear = null
        },
        new CharactersList
        {
            Name = "Annalee Call",
            FilmName = "Alien: Resurrection (1997)",
            Role = "Członkini załogi statku Betty",
            ActorName = "Winona Ryder",
            Species = "Android (Auton)",
            BirthYear = 2381
        },
        new CharactersList
        {
            Name = "Ripley 8",
            FilmName = "Alien: Resurrection (1997)",
            Role = "Klon Ellen Ripley",
            ActorName = "Sigourney Weaver",
            Species = "Hybryda (Człowiek / Obcy)",
            BirthYear = 2381
        },
        new CharactersList
        {
            Name = "The Engineer",
            FilmName = "Prometheus (2012)",
            Role = "Starożytny stwórca ludzi",
            ActorName = "Ian Whyte",
            Species = "Inżynier",
            BirthYear = null
        },
        new CharactersList
        {
            Name = "Neomorph",
            FilmName = "Alien: Covenant (2017)",
            Role = "Forma mutacyjna stworzona przez Davida",
            ActorName = "CGI",
            Species = "Obcy (mutant)",
            BirthYear = null
        },
        new CharactersList
        {
            Name = "Daniels Branson",
            FilmName = "Alien: Covenant (2017)",
            Role = "Oficer kolonizacyjny",
            ActorName = "Katherine Waterston",
            Species = "Człowiek",
            BirthYear = 2100
        }
    };
    
    

}