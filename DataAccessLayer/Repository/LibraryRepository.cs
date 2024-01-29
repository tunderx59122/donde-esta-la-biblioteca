using BusinessObjects.Entity;

namespace DataAccessLayer.Repository
{
    internal class LibraryRepository
    {
        public IEnumerable<Library> GetAll()
        {
            return [];
        }

        public Library Get(int id)
        {
            return new Library(1, "Pablo", "12, rue");
        }
    }
}