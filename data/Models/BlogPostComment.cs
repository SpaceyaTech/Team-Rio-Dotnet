namespace SpaceYaTech.Data.Models;

public class BlogPostComment
{
    public Guid Id { get; set; }
    public Guid BlogPostId { get; set; }
    public Guid UserId { get; set; }
    public string Content { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ParentCommentId { get; set; }

    public BlogPost BlogPost { get; set; }
    public User User { get; set; }
}