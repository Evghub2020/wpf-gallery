using Microsoft.EntityFrameworkCore;
using Tolik.Models;

namespace Tolik.Models
{
    public class ApplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ImageFormat> ImageFormats { get; set; }
        public DbSet<Image> Images { get; set; }

        public ApplicationContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; " +
            "Database=persondb; Trusted_Connection=True;");
        }

    }
}
