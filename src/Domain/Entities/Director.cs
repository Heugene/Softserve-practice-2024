namespace Domain.Entities;

public class Director
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public DateTime Birthday { get; set; }
    public List<Movie> Movies { get; set; }
}