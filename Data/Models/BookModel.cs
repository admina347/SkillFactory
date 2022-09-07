using SkillFactory.Data.Models;
namespace Store
{
    public class Book
    {
        public int Id { get; set; }
        public string Isbn { get; }
        public string Title { get; }
        public string Author { get; }
        public string Description { get; }
        public decimal Price { get;  }
        //public BookGenreModel Genre { get; set; }
        public int GenreId { get; }
        public Book(int id, string isbn, string title, string author, string description, decimal price, int genreid)
        {
            Id = id;
            Isbn = isbn;
            Title = title;
            Author = author;
            Description = description;
            Price = price;
            GenreId = genreid;
        }

        //Book[] GetByTitle(string titlePart)
        /* internal static bool IsIsbn(string s)
        {
            if (s == null)
            return false;
            s = s.Replace("-","")
                 .Replace(" ","")
                 .ToUpper();
            return Regex.IsMatch(s, @"^ISBN\d{10}(\d{3})?$");
        } */
    }
}
