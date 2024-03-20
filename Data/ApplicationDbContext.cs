using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using movieFlix.Models;

namespace movieFlix.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Movie> movie { get; set; }
    }
}
