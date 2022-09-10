using Store.Models;

namespace Store
{
    //Заказ
    //Почему нельзя использовать так?
    //Order<TDelivery> order = new Order<HomeDelivery>();
    public class Order<TDelivery> where TDelivery : Delivery
    {
        public int Id { get; set; }
        public Recipient Recipient;
        public Cart OrderCart;
        //public OrderItem[] cartItems = new OrderItem[0];
        public TDelivery Delivery;
        public static void ShowOrder(Order<HomeDelivery> order)
        {
            Cart.ShowOrderItems(order.OrderCart);
            Console.WriteLine("Способ получения: курьером по адресу");
            Console.WriteLine("Адрес: {0}", order.Delivery.Address);
            Console.WriteLine("Получатель: {0} {1} {2}", order.Recipient.LastName, order.Recipient.Name, order.Recipient.CellPhone);
            Console.WriteLine("Комментарий курьеру: {0}", order.Delivery.Comment);
            if(order.Delivery.toDoor == true)
            {
                Console.WriteLine("Доставка до двери: Да");
            }
            else
            {
                Console.WriteLine("Доставка до двери: Нет");
            }
            Console.WriteLine("Служба доставки: {0} {1}", order.Delivery.Сourier.Name, order.Delivery.Сourier.Phone);
            Console.WriteLine("Дата доставки: {0} {1}", order.Delivery.DeliveryDate.ToString("dddd, dd MMMM yyyy"), order.Delivery.DTime);
            string iStr;
            bool orderAccept;
            Console.WriteLine("Подтвердить заказ?: y/n");
            iStr = Console.ReadLine();
            Helper.ActionAccept(iStr, out orderAccept);
            if(orderAccept == true)
            {
                Console.Clear();
                Console.WriteLine("Ваш заказ отправлен!");
                Console.WriteLine("С вами свяжется наш менеджер для уточнения деталей.");
                Console.WriteLine("Ждем вас снова!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ваш заказ отменен!");
            }
        }
    }
}