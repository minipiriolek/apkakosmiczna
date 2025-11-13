using System.Collections.Generic;

public class FilmList
{
    public string Title { get; set; } = "";
    public string PolishTitle { get; set; } = "";
    public int Year { get; set; } = 0;
    public string Director { get; set; } = "";
    public string Genre { get; set; } = "";
    public int Lenght { get; set; } = 0;
    public double Rating { get; set; } = 0;
    public List<string> MainCharacters { get; set; }
    public string SpaceShip { get; set; } = "";
    public string Description { get; set; } = "";
    public string FunFact { get; set; } = "";
    
}