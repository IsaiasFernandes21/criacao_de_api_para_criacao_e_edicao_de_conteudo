using Microsoft.EntityFrameworkCore;
using ContentManagementAPI.Models; 

namespace ContentManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Content> Contents { get; set; } 
    }
}
