namespace SpaceYaTech.Api.Common;

public class BlogPostRequestModel
{
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int StartIndex { get; set; }
    public int Size { get; set; }
    public bool IsPublished { get; set; }
}