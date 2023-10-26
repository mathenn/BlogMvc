using BlogMvc.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogMvc.Data
{
    public class BlogDbContext : DbContext
    {
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }
    } 
}
