
using BusinessObjects.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class LibraryRepository : IGenericRepository<Library>
    {
        private List<Library> _libraries = new List<Library>();

        public LibraryRepository()
        {
            AddLibrary(new Library { Id = 1, Name = "Bibliothèque Roubaix", Address = "44 Av. Jean Lebas, 59100 Roubaix" });
            AddLibrary(new Library { Id = 2, Name = "Médiathèque Calais", Address = "16 Rue du Pont Lottin, 62100 Calais" });
        }
        public IEnumerable<Library> GetAll()
        {
            return _libraries;
        }

        public IEnumerable<Library> Get(int id)
        {
            return _libraries.Where(library => library.Id == id);
        }

        private void AddLibrary(Library library)
        {
            _libraries.Add(library);
        }

    }
}