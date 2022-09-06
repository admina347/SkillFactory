namespace Store.DB;

public interface IBookRepository
{
    Book[] GetAll();
    Book[] GetAllByTitle(string titlePart);
}
