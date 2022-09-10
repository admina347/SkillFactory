using Store.Models;
namespace Store.Memory
{
    public class PickPointRepository : IPickPointRepository
    {
        private readonly PickPoint[] pickPoints = new[]
        {
            new PickPoint(1, "Ufa47","Постамат","Пн-Пт 10:00-20:00, Сб-Вс 10:00-18:00","Уфа, ул. Достоевского, 83", 5),
            new PickPoint(2, "Ufa17","Пункт выдачи заказов","Пн-Пт 08:00-20:00, Сб-Вс 10:00-20:00","Уфа, Революционная, 98/1 блок А", 7),
            new PickPoint(3, "Ufa35","Пункт выдачи заказов","Пн-Пт 09:00-20:00","Уфа, пр-т Октября, 60", 5),
            new PickPoint(4, "Ufa25","Пункт выдачи заказов, Примерочная","Пн-Пт 09:00-20:00","Уфа, ул. Дорофеева, 3 корп.2", 8),
            new PickPoint(5, "Ufa5","Пункт выдачи заказов, Примерочная","Пн-Пт 09:00-20:00, Сб-Вс 10:00-18:00","Уфа, ул. Маршала Жукова, 10 блок А, 1081", 5)
        };
        public PickPoint[] GetAll()
        {
            return pickPoints;
        }
        public PickPoint GetById(int id)
        {
            return pickPoints.Single(pickPoint => pickPoint.Id == id);
        }
    }
}