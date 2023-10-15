namespace EntityLayer.Concrete;

public class Newsletter : IEntity
{
    public int NewsletterId { get; set; }
    public string? Mail { get; set; }
    public bool Status { get; set; }
}