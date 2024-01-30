using BusinessObjects.Entity;
using Microsoft.EntityFrameworkCore;
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
            optionsBuilder.UseSqlite("../ressources/library.db");
        }
    }
}
