namespace SpaceYaTech.Data.Models;

public class BlogPostMedia
{
    public Guid Id { get; set; }
    public Guid BlogPostId { get; set; }
    public string MediaUrl { get; set; }
    public string MediaAlt { get; set; }
    public string MediaCaption { get; set; }
    
    public BlogPost BlogPost { get; set; }
}