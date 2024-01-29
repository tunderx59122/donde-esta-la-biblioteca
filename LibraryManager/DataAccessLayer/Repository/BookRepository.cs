
using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BookRepository : IRepository<Book>
    {
        private List<Book> _books = new List<Book>();

        public BookRepository()
        {
            AddBook(new Book { Name = "Book1", Pages = 50, Type = BookTypes.ENSEIGNEMENT, Rate = 2, IdAuthor = 1, Id = 1 });
            AddBook(new Book { Name = "Book2", Pages = 60, Type = BookTypes.HISTOIRE, Rate = 3, IdAuthor = 2, Id = 2 });
            AddBook(new Book { Name = "Book3", Pages = 200, Type = BookTypes.FANTASY, Rate = 4, IdAuthor = 1, Id = 3 });
            AddBook(new Book { Name = "Book4", Pages = 150, Type = BookTypes.FANTASY, Rate = 5, IdAuthor = 3, Id = 4 });
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public Book Get(int id)
        {
            return _books.Where(book => book.Id == id);
        }


        private void AddBook(Book book)
        {
            _books.Add(book);
        }

    }
}