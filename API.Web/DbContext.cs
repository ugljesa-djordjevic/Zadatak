using API.Web.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Web
{
    public class DbContext : IdentityDbContext
    {
        public DbContext() { }

        public DbContext(DbContextOptions options) : base(options) { }

        public virtual DbSet<BlogPost> BlogPosts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
