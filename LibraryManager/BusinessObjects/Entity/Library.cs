using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entity
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Adress { get; set; }


        public ICollection<Book> Books { get; set; }
    }
}