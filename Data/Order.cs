using Store.Models;

namespace Store
{
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