namespace SpaceYaTech.Data.Models;

public class BlogPost
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public string Slug { get; set; }
    public bool Published { get; set; }
    
    public User User { get; set; }
}