namespace Domain.Entities;

public class Ticket
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public int MovieSessionId { get; set; }
    public MovieSession MovieSession { get; set; }
    public int TemporaryDiscountId { get; set; }
    public TemporaryDiscount TemporaryDiscount { get; set; }
    public int SeatId { get; set; }
    public Seat Seat { get; set; }
    public DateTime PurchaseDateTime { get; set; }
    public decimal TotalPrice { get; set; }
}