using API.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Web.Services
{
    public class BlogService : IBlogService
    {
        private readonly DbContext _db;
        public BlogService(DbContext dbContext)
        {
            _db = dbContext;
        }

        /// <summary>
        /// Retrieves all Blog posts from the database
        /// </summary>
        /// <returns></returns>
        public List<BlogPost> GetAllPosts()
        {
            return _db.BlogPosts.ToList();
        }

        /// <summary>
        /// Retrieves a BlogPosts by category
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public BlogPost GetPostsByCategory(string category)
        {
            return _db.BlogPosts.Find(category);
        }

        /// <summary>
        /// Sorts a BlogPosts by a inserted sort type
        /// </summary>
        /// <param name="sort"></param>
        /// <returns></returns>
        public List<BlogPost> SortPosts(string order_by, string order)
        {
            if(order_by == "title" || order == "ASC")
            {
                return _db.BlogPosts.OrderBy(item => item.Title)
                                    .ToList();
            }

            else if(order_by == "title" || order == "DESC")
            {
                return _db.BlogPosts.OrderByDescending(item => item.Title)
                                    .ToList();
            }

            else if(order_by == "date" || order == "DESC")
            {
                return _db.BlogPosts.OrderBy(item => item.CreatedAt)
                                    .ToList();
            }

            else
            {
                return _db.BlogPosts.OrderByDescending(item => item.CreatedAt)
                                    .ToList();
            }
        }
    }
}
