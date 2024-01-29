using BusinessObjects.Enums;

namespace BusinessObjects.Entity
{
    /// <summary>
    /// 
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pages { get; set; }
        public BookType Type  { get; set; }
        public int Rate { get; set; }
        public int Id_author { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="pages"></param>
        /// <param name="type"></param>
        /// <param name="rate"></param>
        /// <param name="id_author"></param>
        public Book(int id, string name, int pages, BookType type, int rate, int id_author)
        {
            this.Id = id;
            this.Name = name;
            this.Pages = pages;
            this.Type = type;
            this.Rate = rate;
            this.Id_author = id_author;
        }


    }
}
