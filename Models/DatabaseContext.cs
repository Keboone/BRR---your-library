using Microsoft.EntityFrameworkCore;

namespace LibraryFinal.Models
{
    public class DatabaseContext: DbContext
{
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options) {}
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
