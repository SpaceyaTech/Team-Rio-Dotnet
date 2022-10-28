namespace SpaceYaTech.Data.Models;

public class BlogPost
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public string Slug { get; set; }
    public bool IsPublished { get; set; }

    public User User { get; set; }
}