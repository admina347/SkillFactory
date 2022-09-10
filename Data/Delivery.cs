using Store.Models;

namespace Store
{
    public abstract class Delivery
    {  
        internal readonly string[] PaymentType = new[] {"Наличными при получении", "Банковской картой"};
        //public string Phone;
        public DateTime DeliveryDate { get; set; }
    }
    //Доставка до двери
    public class HomeDelivery : Delivery
    {
        //Курьерская служба выбор
        public Courier Сourier;
        public string Address;
        public string Comment { get; set; }
        public bool toDoor { get; set; }
        public string DTime { get; set; }
        
        /* доставка на дом. Этот тип будет подразумевать наличие курьера или передачу курьерской компании, в нем будет располагаться своя, отдельная от прочих типов доставки логика. */
    }
    public class PickPointDelivery : Delivery
    {
        public PickPoint PickPoint;
        
        //пункты выдачи
        //срок хранения

        /* доставка в пункт выдачи. Здесь будет храниться какая-то ещё логика, необходимая для процесса доставки в пункт выдачи, например,
        хранение компании и точки выдачи, а также какой-то ещё информации. */
    }

    public class ShopDelivery : Delivery
    {
        /* доставка в розничный магазин. Эта доставка может выполняться внутренними средствами компании и совсем не требует работы с «внешними&raquo; элементами. */
    }
}