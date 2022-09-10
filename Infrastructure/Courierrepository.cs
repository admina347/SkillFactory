using Store.Models;
namespace Store.Memory
{
    public class CourierRepository
    {
        private readonly Courier[] couriers = new[]
        {
            new Courier("СДЭК","+7(347)266-54-05"),
            new Courier("DPD","+7 (800) 234 45 95"),
            new Courier("Яндекс Go","+7 (495) 032-63-33"),
            new Courier("EMS","8-800-100-00-00"),
            new Courier("DHL","+7 (495) 956-1000")
        };
        public Courier[] GetAll()
        {
            return couriers;
        }
    }
}