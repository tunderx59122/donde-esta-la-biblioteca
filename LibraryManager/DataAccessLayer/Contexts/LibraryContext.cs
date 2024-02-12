using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.Contexts
{
    public class LibraryContext : DbContext
    {

        //constructeur par defaut
        public LibraryContext() {}

        //définir les DbSet
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Library> Libraries { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> dbContextOptions) : base(dbContextOptions) {}

        // on définit les relations
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
               .HasOne(bl => bl.Book)
               .WithMany(b => b.Libraries)
               .HasForeignKey(bl => bl.Id);

            modelBuilder.Entity<Book>()
                .HasOne(bl => bl.Library)
                .WithMany(l => l.Libraries)
                .HasForeignKey(bl => bl.Id);

            modelBuilder.Entity<Author>()
                .HasMany(e => e.Books)
                .WithOne(e => e.Author);

            modelBuilder.Entity<Library>()
                .HasMany(e => e.Books);
        }
    }
}
