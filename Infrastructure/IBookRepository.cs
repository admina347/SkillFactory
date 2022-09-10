using Store.Models;
namespace Store.Memory;

public interface IBookRepository
{
    Book[] GetAll();
    Book[] GetAllByTitle(string titlePart);
    Book GetById(int id);
}
