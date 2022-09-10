using Store.Models;

namespace Store
{
    public class Recipient
    {
        public string Name
        {
            get {return Name; }
            set
            {
                //Имя
                while (Helper.ChekStr(value))
                {
                    Console.WriteLine("Введите свое Имя");
                    value = Console.ReadLine();
                }

            }
        }
        public string LastName
        {
            get { return LastName; }
            set
            {
                //Фамилия
                while (Helper.ChekStr(value))
                {
                    Console.WriteLine("Введите свою Фамилию");
                    value = Console.ReadLine();
                }
            }
        }
        public string CellPhone
        {
            get { return CellPhone; }
            set
            {
               //телефон
                while (Helper.CheckPhone(value))
                {
                    Console.WriteLine("Введите номер мобильного");
                    value = Console.ReadLine();
                } 
            }
        }
    }
    public class Сourier
    {
        string Name { get; }
        string Phone { get; }
    }
    //Заказ
    public class Order<TDelivery> where TDelivery : Delivery
    {
        public int Id { get; set; }
        public Recipient OredrRecipient;
        private CartItem[] CartItems;
        //public OrderItem[] cartItems = new OrderItem[0];

        public TDelivery Delivery;
        public string Description;
        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
        
    }
}