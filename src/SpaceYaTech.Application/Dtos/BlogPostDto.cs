namespace SpaceYaTech.BusinessLayerLogic.Dtos;

public class BlogPostDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public string Slug { get; set; }
}