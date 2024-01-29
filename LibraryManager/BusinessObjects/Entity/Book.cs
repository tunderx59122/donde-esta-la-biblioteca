using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entity
{
    public enum BookTypes
    {
        AVENTURE,
        ENSEIGNEMENT,
        HISTOIRE,
        JURIDIQUE,
        FANTASY
    }

    public class Book
    {
        public int id { get; set; }
        public string Name { get; set; }

        public int Pages { get; set; }

        public BookTypes Type { get; set; }


        public int Rate { get; set; }

        public int Id_Author { get; set; }
        public Author Author { get; set; }

        public ICollection<Library> Libraries { get; set; }
    }
}