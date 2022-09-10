using SkillFactory.Data.Models;

namespace Store.Memory;

public interface IBookGenreRepository
{
    BookGenreModel[] GetAll();
    BookGenreModel GetById(int id);
}
