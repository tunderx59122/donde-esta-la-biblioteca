using System.ComponentModel.DataAnnotations;

namespace BusinessObjects.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class Library
    {
        [Key]
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
