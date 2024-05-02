namespace Domain.Entities;

public class TemporaryDiscount
{
    public int Id { get; set; }
    public int? MovieId { get; set; }
    public int? GenreId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDateTime { get; set; }
    public DateTime EndDateTime { get; set; }
    public bool IsEveryWeek { get; set; }
    public bool IsEveryMonth { get; set; }
    public bool IsEveryYear { get; set; }
    public byte DiscountPercentage { get; set; }
    public string ImageUrl { get; set; }
}