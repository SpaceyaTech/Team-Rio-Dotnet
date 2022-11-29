namespace SpaceYaTech.Data.Models;

public class BlogPost
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public string Title { get; set; }
    public string BlogDescription { get; set; }
    public string Content { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime? DateUpdated { get; set; }
    public string Slug { get; set; }
    public bool IsPublished { get; set; }

    public Account Account { get; set; }
}