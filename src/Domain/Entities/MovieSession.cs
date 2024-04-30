namespace Domain.Entities;

public class MovieSession
{
    public int Id { get; set; }
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    public decimal Price { get; set; }
    public DateTime StartDateTime { get; set; }
    public int LocationId { get; set; }
    public Location Location { get; set; }
}