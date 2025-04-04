using BulkyWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        // How will we get connection string from appsettings.json
        // Inject ApplicationDbContext / Configure ApplicationDbContext, we will get connectionstring as a parameter in constructor as DbContext option and we will be passing on to base class

        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base (options)
        {

            
        }
        // EFcore automatically creates table in SQL Table
        public DbSet<Category> Categories { get; set; }

        // Overriding a model builder
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 11, Name = "Drama", DisplayOrder = 1 },
                new Category { Id=12, Name="Booze", DisplayOrder=2}
                );
        }
    }
}
