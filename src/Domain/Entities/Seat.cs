using Domain.Enums;

namespace Domain.Entities;

public class Seat
{
    public int Id { get; set; }
    public SeatType SeatType { get; set; }
    public int LocationId { get; set; }
    public ushort SeatNumber { get; set; }
    public byte PriceModifier { get; set; }
}