using API.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Web.Services
{
    public interface IBlogService
    {
        List<BlogPost> GetAllPosts();
        BlogPost GetPostsByCategory(string category);
        List<BlogPost> SortPosts(string order_by, string order);

    }
}
