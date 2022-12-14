namespace SpaceYaTech.Data.Models;

public class BlogPostComment
{
    public int Id { get; set; }
    public int BlogPostId { get; set; }
    public int AccountId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public int? ParentCommentId { get; set; }

    public BlogPost BlogPost { get; set; }
    public Account Account { get; set; }
}