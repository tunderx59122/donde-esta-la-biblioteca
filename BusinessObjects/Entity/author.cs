namespace BusinessObjects.Entity
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Author(int id, string firstName, string lastName)
        {
            Id = 0;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
