using BusinessObjects.Entity;
using BusinessObjects.Enums;
using DataAccessLayer.Repository;

namespace BusinessLayer.Catalog
{
    public class LibraryManager : ILibraryManager
    {
        public IGenericRepository<Library> _libraryRepository;

        public LibraryManager(IGenericRepository<Library> libraryRepository)
        {
            _libraryRepository = libraryRepository;
        }

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
