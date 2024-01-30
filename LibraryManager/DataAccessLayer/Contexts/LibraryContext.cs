using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.Contexts
{
    public class LibraryContext : DbContext
    {

        //public void ConfigureServices(ICatalogService services) { 
        //        services.AddDbContext<LibraryContext>(options =>
        //              options.UseSqlite("Data Source={path};"));
        //}
    }
}
