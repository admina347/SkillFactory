using SkillFactory.Data.Models;
namespace Store.Models
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
        public static void ShowBooksPreview(Book[] books, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Книга {0}: {1} Цена: {2}р.", books[i].Id, books[i].Title, books[i].Price);
            }
        }
        public static void ShowBooksAll(Book[] books)
        {
            Console.WriteLine("Все книги:");
            foreach(var item in books)
            {
                Console.WriteLine("Книга {0}: {1} Цена: {2}р.", item.Id, item.Title, item.Price); 
            } 
        }
        public static void ShowBook(Book book, string genre)
        {
            Console.WriteLine("Книга №{0} ", book.Id);
            Console.WriteLine("ISBN: {0}", book.Isbn);
            Console.WriteLine("Жанр: {0}", genre);
            Console.WriteLine("Название: {0}", book.Title);
            Console.WriteLine("Автор: {0}", book.Author);
            Console.WriteLine("Краткое описание: {0}", book.Description);
            Console.WriteLine("Цена: {0}р.", book.Price);
        }
    }
}
