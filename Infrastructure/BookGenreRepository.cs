using SkillFactory.Data.Models;

namespace Store.Memory;

public class BookGenreRepository : IBookGenreRepository
{
    private readonly BookGenreModel[] genres = new[]
    {
        new BookGenreModel(1, "Фантастика"),
        new BookGenreModel(2, "Детективы"),
        new BookGenreModel(3, "Любовные романы"),
        new BookGenreModel(4, "Приключения"),
        new BookGenreModel(5, "Классика жанра"),
        new BookGenreModel(6, "Фэнтези")
    };
    public BookGenreModel[] GetAll()
    {
        return genres;
    }
    public BookGenreModel GetById(int id)
    {
        return genres.Single(genre => genre.Id == id);
    }
}