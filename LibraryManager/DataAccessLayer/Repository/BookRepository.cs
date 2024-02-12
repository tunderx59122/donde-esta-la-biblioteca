
using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class BookRepository : IGenericRepository<Book>
    {
        private List<Book> _books = new List<Book>();

        public BookRepository()
        {
            AddBook(new Book {Id = 1, Name = "Le conte de Monte Cristo", Pages = 900, Type = BookTypes.AVENTURE, Rate = 10, IdAuthor = 1 });
            AddBook(new Book {Id = 2, Name = "Les trois mousquetaires", Pages = 300, Type = BookTypes.AVENTURE, Rate = 9, IdAuthor = 1 });
            AddBook(new Book {Id = 3, Name = "Apprendre le Java mais pas sur l'île de Java", Pages = 900, Type = BookTypes.ENSEIGNEMENT, Rate = 8, IdAuthor = 2 });
            AddBook(new Book {Id = 4, Name = "Le RC Lense, un club pas comme les autres", Pages = 900, Type = BookTypes.HISTOIRE, Rate = 5, IdAuthor = 4 });
            AddBook(new Book { Id = 5, Name = "La RGPD, une protection contre l 'injustice", Pages = 900, Type = BookTypes.JURIDIQUE, Rate = 6, IdAuthor = 1 });

        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public IEnumerable<Book> Get(int id)
        {
            return _books.Where(book => book.Id == id);
        }

        private void AddBook(Book book)
        {
            _books.Add(book);
        }

    }
}