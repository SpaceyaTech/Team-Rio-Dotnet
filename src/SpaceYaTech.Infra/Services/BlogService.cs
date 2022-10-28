using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SpaceYaTech.BusinessLayerLogic.Dtos;
using SpaceYaTech.BusinessLayerLogic.Interfaces;
using SpaceYaTech.Data;
using SpaceYaTech.Data.Models;

namespace SpaceYaTech.Infra.Services;

public class BlogService : IBlogService
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public BlogService(DatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task CreateBlogPostAsync(BlogPostDto blogPostDto)
    {
        var newBlogPost = _mapper.Map<BlogPost>(blogPostDto);
        newBlogPost.DateCreated = DateTime.Now;
        newBlogPost.IsPublished = false;
        newBlogPost.Slug = newBlogPost.Title.ToLower().Replace(" ", "-");

        _context.BlogPosts.Add(newBlogPost);
        await _context.SaveChangesAsync();
    }

    public async Task PublishBlogPostAsync(Guid blogPostId)
    {
        var blogPost = await _context.BlogPosts.FindAsync(blogPostId);
        if (blogPost == null)
        {
            throw new Exception("Blog post not found");
        }

        blogPost.IsPublished = true;

        _context.BlogPosts.Update(blogPost);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<BlogPostDto>> GetBlogPostsAsync(
        DateTime? startDate,
        DateTime? endDate,
        int? startIndex,
        int? size,
        bool? isPublished)
    {
        var query = _context.BlogPosts.AsQueryable();

        if (startDate.HasValue)
        {
            query = query.Where(x => x.DateCreated >= startDate);
        }

        if (endDate.HasValue)
        {
            query = query.Where(x => x.DateCreated <= endDate);
        }

        if (isPublished.HasValue)
        {
            query = query.Where(x => x.IsPublished == isPublished);
        }

        if (startIndex.HasValue && size.HasValue)
        {
            query = query.Skip(startIndex.Value).Take(size.Value);
        }

        var blogPosts = await query.OrderByDescending(x => x.DateCreated).ToListAsync();

        return _mapper.Map<IEnumerable<BlogPostDto>>(blogPosts);
    }
}