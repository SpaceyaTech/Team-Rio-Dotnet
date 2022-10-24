using Microsoft.EntityFrameworkCore;
using SpaceYaTech.Data.Models;

namespace SpaceYaTech.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<BlogPost>(entity =>
        {
            entity.Property(e => e.Content).IsRequired().HasColumnType("text");
        });
        
        modelBuilder.Entity<BlogPostComment>(entity =>
        {
            entity.Property(e => e.Content).IsRequired().HasColumnType("text");
        });
    }

    public DbSet<User> Users { get; set; }
    public DbSet<BlogPost> BlogPosts { get; set; }
    public DbSet<BlogPostComment> BlogPostComments { get; set; }
    public DbSet<BlogPostMedia> BlogPostMedia { get; set; }
}