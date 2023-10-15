namespace EntityLayer.Concrete;

public class SubAbout : IEntity
{
    public int SubAboutId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public bool Status { get; set; }
}