namespace EntityLayer.Concrete;

public class Comment : IEntity
{
    public int CommentId { get; set; }
    public string? CommentUser { get; set; }
    public string? CommentContent { get; set; }
    public DateTime CommentDate { get; set; }
    public bool CommentStatus { get; set; }

    public int DestinationId { get; set; }
    public Destination? Destination { get; set; }
}