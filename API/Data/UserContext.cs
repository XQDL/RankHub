using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace API_RankHub.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {

        }

        public DbSet<User> User { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
               builder.Entity<User>().HasKey(m => m.Id);
               base.OnModelCreating(builder);
        }


    }
}