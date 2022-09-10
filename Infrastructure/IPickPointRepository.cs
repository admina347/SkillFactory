namespace Store.Memory
{
    public interface IPickPointRepository
    {
        PickPoint[] GetAll();
        PickPoint GetById(int id);
    }
}