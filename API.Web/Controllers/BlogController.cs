using API.Web.Data;
using API.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Web.Controllers
{
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly ILogger<BlogController> _logger;
        private readonly IBlogService _blogService;

        public BlogController(ILogger<BlogController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/api/v1/posts")]
        public ActionResult GetPosts()
        {
            _logger.LogInformation("Getting all posts");
            var posts = _blogService.GetAllPosts();
            return Ok(posts);
        }

        [HttpGet("/api/v1/posts?category={name}")]
        public ActionResult GetPostByCategory(string name)
        {
            _logger.LogInformation("Getting posts with selected category");
            var posts = _blogService.GetPostsByCategory(name);
            return Ok(posts);
        }

        [HttpGet("/api/v1/posts?order_by={order_by}&order={order}")]
        public ActionResult SortPosts(string order_by, string order)
        {
            _logger.LogInformation("Sorting posts");
            var posts = _blogService.SortPosts(order_by, order);
            return Ok(posts);
        }
    }
}
