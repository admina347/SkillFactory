using Store.Models;
namespace Store.DB;

public interface IBookRepository
{
    Book[] GetAll();
    Book[] GetAllByTitle(string titlePart);
    Book GetById(int id);
}
