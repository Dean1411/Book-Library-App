using Book_Library.Models;
using Microsoft.EntityFrameworkCore;


namespace Book_Library.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        public DbSet<Books> Books { get; set; }
    }
}
