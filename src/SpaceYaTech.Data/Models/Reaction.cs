namespace SpaceYaTech.Data.Models;

public class Reaction
{
    public int Id { get; set; }
    public int ReactionType { get; set; }
    public int BlogPostId { get; set; }
    public int AccountId { get; set; }
    public int BlogPostCommentId { get; set; }

    public BlogPost BlogPost { get; set; }
    public Account Account { get; set; }
    public BlogPostComment BlogPostComment { get; set; }
}