using Store.Models;
namespace Store.Memory
{
    public class CourierRepository : ICourierRepository
    {
        private readonly Courier[] couriers = new[]
        {
            new Courier(1, "СДЭК", "+7(347)266-54-05"),
            new Courier(2, "DPD", "+7 (800) 234 45 95"),
            new Courier(3, "Яндекс Go", "+7 (495) 032-63-33"),
            new Courier(4, "EMS", "8-800-100-00-00"),
            new Courier(5, "DHL", "+7 (495) 956-1000")
        };
        public Courier[] GetAll()
        {
            return couriers;
        }
        public Courier GetById(int id)
        {
            return couriers.Single(courier => courier.Id == id);
        }
    }
}