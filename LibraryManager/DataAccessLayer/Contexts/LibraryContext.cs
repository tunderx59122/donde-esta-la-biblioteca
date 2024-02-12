using System;
using System.Collections.Generic;
using System.Linq;
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
        public LibraryContext()
        { 
        }

        //définir les DbSet
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Library> Libraries { get; set; }


        // on définit les relation : asOne etc + def des clés etrangeres


    }
}
