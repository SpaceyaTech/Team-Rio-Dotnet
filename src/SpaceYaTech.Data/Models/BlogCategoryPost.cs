namespace SpaceYaTech.Data.Models;

public class BlogCategoryPost
{
    public int Id { get; set; }
    public int BlogCategoryId { get; set; }
    public int BlogPostId { get; set; }

    public BlogCategory BlogCategory { get; set; }
    public BlogPost BlogPost { get; set; }
}