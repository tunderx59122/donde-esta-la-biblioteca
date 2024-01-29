using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class Author : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
