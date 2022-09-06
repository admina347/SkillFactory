namespace Store.DB;
public class BookRepository
{
    private readonly Book[] books = new[]
    {
        new Book(1, "9785170882700", "Тёмная сторона", "Макс Фрай", "«Тёмная сторона» – это не метафора, а совершенно конкретное место, изнанка реальности. Тёмная сторона есть у любого города, деревни, леса и даже моря.",269m)
    };
    public Book[] GetAllBytitle(string titlePart)
    {
        throw new NotImplementedException();
    }
}