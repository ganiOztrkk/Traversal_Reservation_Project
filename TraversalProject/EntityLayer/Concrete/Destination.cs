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
}