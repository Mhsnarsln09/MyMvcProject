using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryProject.Models;

    public class LibararyDbContext : DbContext
    {
        public LibararyDbContext (DbContextOptions<LibararyDbContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryProject.Models.BookType> BookType { get; set; } = default!;
    }
