namespace BusinessObjects.Entity
{
    public class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }

        public Library(int id, string name, string adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }
    }
}
