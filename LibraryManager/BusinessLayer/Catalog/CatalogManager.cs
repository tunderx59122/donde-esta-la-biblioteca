using BusinessObjects.Entity;
using DataAccessLayer.Repository;


namespace BusinessLayer.Catalog
{
    public class CatalogManager : ICatalogManager
    {
        //igenericBookRepository
        private readonly IRepository _bookRepository;

        public CatalogManager(IRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> DisplayCatalog()
        {
            var books = _bookRepository.GetAll();
            Console.WriteLine("La liste des livres :");
            foreach (Book book in books)
            {
                Console.WriteLine(book.Name);
            }
            throw new Exception();
        }

        public IEnumerable<Book> DisplayCatalog(BookTypes type)
        {
            var books = _bookRepository.GetAll();
            Console.WriteLine($"La liste des livres du type {type} :");
            foreach (Book book in books)
            {
                if (book.Type == type)
                {
                    Console.WriteLine(book.Name);

                }
            }
            throw new Exception();
        }

        public Book FindBook(int id)
        {
            Book book = (Book)_bookRepository.Get(id);
            Console.WriteLine($"Book avec l'ID {book.Id} {book.Name}");
            return book;
        }

        public IEnumerable<Book> GetBooksFantasy()
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