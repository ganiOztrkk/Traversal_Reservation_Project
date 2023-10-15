namespace EntityLayer.Concrete;

public class Contact : IEntity
{
    public int ContactId { get; set; }
    public string? Description { get; set; }
    public string? Mail { get; set; }
    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? MapLocation { get; set; }
    public bool Status { get; set; }
}