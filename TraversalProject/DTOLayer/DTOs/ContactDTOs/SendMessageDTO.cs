namespace DTOLayer.DTOs.ContactDTOs;

public class SendMessageDTO
{
    public string Name { get; set; }
    public string Mail { get; set; }
    public string Subect { get; set; }
    public string MessageBody { get; set; }
    public DateTime MessageDate { get; set; }
}