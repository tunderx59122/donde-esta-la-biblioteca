using BusinessObjects.Entity;
using DataAccessLayer.Data;
using DataAccessLayer.Repository;


namespace BusinessLayer.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        private BookRepository _bookRepository;

        public CatalogManager(DataContext context)
        {
            _bookRepository = new BookRepository(context);
        }

        public async Task DisplayCatalog()
        {
            List<Book> books = await _bookRepository.GetAll();
            Console.WriteLine("La liste des livres :");
            foreach (Book book in books)
            {
                Console.WriteLine(book.Name);
            }
        }

        public async Task DisplayCatalog(Type type)
        {
            List<Book> books = await _bookRepository.GetAll();
            Console.WriteLine($"La liste des livres du type {type} :");
            foreach (Book book in books)
            {
                if (book.Type == type)
                {
                    Console.WriteLine(book.Name);

                }
            }
        }

        public async Task<Book> FindBook(int id)
        {
            Book book = await _bookRepository.Get(id);
            Console.WriteLine($"Book avec l'ID {book.Id} {book.Name}");
            return book;
        }

        public List<Book> GetBooksFantasy()
        {
            List<Book> books = _bookRepository.GetAll().ToList();

            IEnumerable<Book> booksQuery =
                from book in books
                where book.Type == BookTypes.FANTASY
                select book;

            Console.WriteLine("La liste des livres de type fantasy :");
            foreach (Book book in booksQuery)
            {
                Console.WriteLine(book.Name);
            }
            return books;
        }

        public Book GetBookBestRated()
        {
            List<Book> books = _bookRepository.GetAll().ToList();

            Book book = books.OrderByDescending(book => book.Rate).First();

            Console.WriteLine($"Le livre avec le mieux noté est {book.Name} avec {book.Rate}");

            return book;
        }


    }
}