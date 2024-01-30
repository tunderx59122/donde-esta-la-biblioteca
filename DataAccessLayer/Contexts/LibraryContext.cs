using BusinessObjects.Entity;
using BusinessObjects.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Reflection.Metadata;

namespace DataAccessLayer.Contexts
{
    public class LibraryContext : DbContext
    {
        public DbSet<Author> _authors { get; set; }
        public DbSet<Book> _books { get; set; }
        public DbSet<Library> _libraries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../ressources/library.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Book>()
            .Property(e => e.Type)
            .HasConversion(
                v => v.ToString(),
                v => (BookType)Enum.Parse(typeof(BookType), v));
        }
    }
}
