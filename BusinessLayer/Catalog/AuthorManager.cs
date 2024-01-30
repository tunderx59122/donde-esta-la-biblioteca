using BusinessObjects.Entity;
using BusinessObjects.Enums;
using DataAccessLayer.Repository;

namespace BusinessLayer.Catalog
{
    public class AuthorManager : IAuthorManager
    {
        AuthorRepository _authorRepository = new AuthorRepository();

        public List<Author> DisplayAuthors()
        {
            return _authorRepository.GetAll();
        }

        public Author FindAuthor(int id)
        {
            return _authorRepository.Get(id);
        }
    }
}
