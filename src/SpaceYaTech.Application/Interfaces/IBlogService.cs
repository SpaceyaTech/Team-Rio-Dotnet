using SpaceYaTech.BusinessLayerLogic.Dtos;

namespace SpaceYaTech.BusinessLayerLogic.Interfaces;

public interface IBlogService
{
    Task CreateBlogPostAsync(BlogPostDto blogPostDto);
    Task PublishBlogPostAsync(Guid blogPostId);

    Task<IEnumerable<BlogPostDto>> GetBlogPostsAsync(
        DateTime? startDate,
        DateTime? endDate,
        int? startIndex,
        int? size,
        bool? isPublished);
}