using System.Collections.Generic;

namespace apkakosmiczna.Models;

public class FilmList
{
    public string Title { get; set; } = "";
    public string PolishTitle { get; set; } = "";
    public int? Year { get; set; }
    public string Director { get; set; } = "";
    public string Genre { get; set; } = "";
    public int? Lenght { get; set; }
    public double? Rating { get; set; }
    public List<string> MainCharacters { get; set; }
    public string SpaceShip { get; set; } = "";
    public string Description { get; set; } = "";
    public string FunFact { get; set; } = "";
    
}