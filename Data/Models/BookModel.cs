namespace Store
{
    public class Book
    {
        public int Id { get; set; }
        public string Isbn { get; set; }
        public string Title { get; }
        public string Author { get; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Book(int id, string isbn, string title, string author, string description, decimal price)
        {
            Id = id;
            Isbn = isbn;
            Title = title;
            Author = author;
            Description = description;
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
