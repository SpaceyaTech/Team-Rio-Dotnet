using Microsoft.AspNetCore.Mvc;
using SpaceYaTech.Api.Common;
using SpaceYaTech.BusinessLayerLogic.Dtos;
using SpaceYaTech.BusinessLayerLogic.Interfaces;

namespace SpaceYaTech.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blogService;

        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }

        [HttpPost("CreateBlog")]
        public async Task<IActionResult> CreateBlog([FromBody] BlogPostDto blogPost)
        {
            await _blogService.CreateBlogPostAsync(blogPost);
            return Ok();
        }

        [HttpPost("PublishBlog")]
        public async Task<IActionResult> PublishBlog([FromBody] BlogPostDto blogPost)
        {
            await _blogService.PublishBlogPostAsync(blogPost.Id);
            return Ok();
        }

        [HttpGet("GetBlogPosts")]
        public async Task<IActionResult> GetBlogPosts([FromQuery] BlogPostRequestModel requestModel)
        {
            var blogs = await _blogService.GetBlogPostsAsync(
                requestModel.StartDate, requestModel.EndDate, requestModel.StartIndex, requestModel.StartIndex,
                requestModel.IsPublished);
            return Ok(blogs);
        }
    }
}