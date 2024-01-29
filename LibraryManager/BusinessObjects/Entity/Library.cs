using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Entity
{
    public class Library
    {
        public required int Id { get; set; }
        public string? Name { get; set; }

        public string? Address { get; set; }


        public ICollection<Book>? Books { get; set; }
    }
}