using Microsoft.EntityFrameworkCore;
using LibraryData.Models;

namespace LibraryData
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options) { }

        public DbSet<Patron> Patron { get; set; }
    }
}
