using Store.Models;
namespace Store.Memory
{
    public interface ICourierRepository
    {
        Courier[] GetAll();
        Courier GetById(int id);
    }
}