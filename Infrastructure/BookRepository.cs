using System;
using System.Linq;

namespace Store.DB;

public class BookRepository : IBookRepository
{
    private readonly Book[] books = new[]
    {
        new Book(1, "9785170882700", "Тёмная сторона", "Макс Фрай", "«Тёмная сторона» – это не метафора, а совершенно конкретное место, изнанка реальности. Тёмная сторона есть у любого города, деревни, леса и даже моря.", 269m),
        new Book(2, "9785170882700978-5-271-40351-4", "Ведьмак", "Анджей Сапковский", "«Геральт из Ривии – ведьмак, один из немногих представителей некогда большого и могущественного дома борцов с нечистью. Он один из лучших в своем деле, с детства наученный убивать упырей, ведьм, леших и всех, кто так или иначе угрожает людям.", 1499m)
    };
    public Book[] GetAll()
    {
        return books;
    }
    public Book[] GetAllByTitle(string titlePart)
    {
        return books.Where(book => book.Title.Contains(titlePart))
                    .ToArray();
    }
}