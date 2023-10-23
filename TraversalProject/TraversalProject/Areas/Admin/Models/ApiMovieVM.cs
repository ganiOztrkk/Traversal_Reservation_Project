namespace TraversalProject.Areas.Admin.Models;

public class ApiMovieVM
{
    public long Rank { get; set; }
    public string Title { get; set; }
    public Uri? Thumbnail { get; set; }
    public string Rating { get; set; }
    public string? Id { get; set; }
    public long Year { get; set; }
    public Uri? Image { get; set; }
    public Uri? BigImage { get; set; }
    public string? Description { get; set; }
    public Uri? Trailer { get; set; }
    public Uri? TrailerEmbedLink { get; set; }
    public string? TrailerYoutubeId { get; set; }
    public List<string>? Genre { get; set; }
    public List<string>? Director { get; set; }
    public List<string>? Writers { get; set; }
    public string? Imdbid { get; set; }
    public Uri? ImdbLink { get; set; }
}