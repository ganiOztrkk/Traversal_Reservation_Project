namespace EntityLayer.Concrete;

public class Reservation : IEntity
{
    public int ReservationId { get; set; }
    public int AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
    public string? PersonCount { get; set; }
    public string? Destination { get; set; }
    public DateTime? ReservationDate { get; set; }
    public string? Description { get; set; }
    public string? Status { get; set; }
}