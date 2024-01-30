using BusinessObjects.Entity;
using BusinessObjects.Enums;
using DataAccessLayer.Repository;

namespace BusinessLayer.Catalog
{
    public class LibraryManager : ILibraryManager
    {
        LibraryRepository _libraryRepository = new LibraryRepository();

        public List<Library> DisplayLibraries()
        {
            return _libraryRepository.GetAll();
        }

        public Library DisplayLibrary(int id)
        {
            return _libraryRepository.Get(id);
        }
    }
}
