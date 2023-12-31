namespace EntityLayer.Concrete;

public class Destination : IEntity
{
    public int DestinationId { get; set; }
    public string? City { get; set; }
    public string? DayNight { get; set; }
    public double Price { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    public int Capasity { get; set; }
    public bool Status { get; set; }
    public string? CoverImage { get; set; }
    public string? Details1 { get; set; }
    public string? Details2 { get; set; }
    public string? ImageUrl2 { get; set; }

    public List<Comment>? Comments { get; set; }
    public List<Reservation>? Reservations { get; set; }
}