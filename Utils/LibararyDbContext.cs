using LibraryProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryProject.Utility
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) {}
        public DbSet<BookType> BookTypes { get; set; }

    }

}