namespace EntityLayer.Concrete;

public class ContactMessage : IEntity
{
    public int ContactMessageId { get; set; }
    public string Name { get; set; }
    public string Mail { get; set; }
    public string Subect { get; set; }
    public string MessageBody { get; set; }
    public DateTime MessageDate { get; set; }
}