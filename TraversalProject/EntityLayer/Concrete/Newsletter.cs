namespace EntityLayer.Concrete;

public class Newsletter : IEntity
{
    public int NewletterId { get; set; }
    public string? Mail { get; set; }
    public bool Status { get; set; }
}