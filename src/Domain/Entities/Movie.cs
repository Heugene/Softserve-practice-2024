namespace Domain.Entities;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Slogan { get; set; }
    public List<Genre> Genres { get; set; }
    public List<Actor> Actors { get; set; }
    public byte AgeRestriction { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Duration { get; set; }
    public int DirectorId { get; set; }
    public Director Director { get; set; }
    public string PosterUrl { get; set; }
    public string TrailerUrl { get; set; }
    public double Raiting { get; set; }
}