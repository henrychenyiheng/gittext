using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            : base(options)
        { }

        public DbSet<Books> Books { get; set; }

        public DbSet<WebApplication1.Models.Book> Book { get; set; }
    }

    public class Books
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string ISNB { get; set; }
    }

    public class Book
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string ISNB { get; set; }

    }
}