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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../ressources/library.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>()
                .HasOne(e => e.Author)
                .WithMany(e => e.Books)
                .HasForeignKey("id_author");

            modelBuilder.Entity<Author>()
                .HasMany(e => e.Books)
                .WithOne(e => e.Author);

            modelBuilder.Entity<Library>()
                .HasMany(e => e.Books);
        }
    }
}
