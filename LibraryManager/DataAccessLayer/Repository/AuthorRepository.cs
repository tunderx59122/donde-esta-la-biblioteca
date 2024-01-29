
using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class AuthorRepository : Author
    {
        private List<Author> _authors = new List<Author>();

        public AuthorRepository()
        {
            AddAuthor(new Author { Id = 1, FirstName = "Alexandre", LastName = "Dumas" });
            AddAuthor(new Author { Id = 2, FirstName = "Remi", LastName = "Synave" });
            AddAuthor(new Author { Id = 3, FirstName = "Dany", LastName = "Capitaine" });
            AddAuthor(new Author { Id = 4, FirstName = "Severine", LastName = "Letrez" });
        }
        public IEnumerable<Author> GetAll()
        {
            return _authors;
        }

        public IEnumerable<Author> Get(int id)
        {
            return _authors.Where(author => author.Id == id);
        }

        private void AddAuthor(Author author)
        {
            _authors.Add(author);
        }

    }
}