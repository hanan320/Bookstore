using Bookstore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Bookstore.Data
{
    public class BookstoreDbContext : DbContext
    {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

    }
}
