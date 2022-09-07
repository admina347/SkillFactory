using SkillFactory.Data.Models;

namespace Store.DB;

public interface IBookGenreRepository
{
    BookGenreModel[] GetAll();
    BookGenreModel GetById(int id);
}
