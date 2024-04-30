namespace Domain.Entities;

public class Location
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CityId { get; set; }
    public City City { get; set; }
    public string Address { get; set; }
    public List<Seat> Seats { get; set; }
    public byte RowsQuantity { get; set; }
    public byte ColumnsQuantity { get; set; }
}