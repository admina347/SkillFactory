namespace Store.Models
{
    class Cart
    {
        //public int Id { get; set; }
        public static CartItem[] CartItems { get; set; } = new CartItem[0];
        public int TotalCount
        {
            get { return CartItems.Sum(CartItems => CartItems.Count); }
        }
        public decimal TotalPrice
        {
            get { return CartItems.Sum(CartItems => CartItems.Price * CartItems.Count); }
        }
        public Cart(CartItem[] cartItems)
        {
            CartItems = cartItems;
        }
        public static void ShowCart(Cart cart)
        {
            //вывесли позиции заказа (корзины)
            Console.WriteLine("В корзине:");
            if (CartItems.Length > 0)
            {
                foreach (var item in CartItems)
                {
                    Console.WriteLine("Товар {0}: {1} кол-во: {2}, Цена: {3}р. Сумма: {4}р.", item.Id, item.Book.Title, item.Count, item.Price, item.Sum);

                }
                //Total
                Console.WriteLine("Всего позиций: {0}, кол-во товара: {1}, Итого: {3}р.", CartItems.Count(), cart.TotalCount, cart.TotalPrice);
            }
            else
            {
                Console.WriteLine("Нет товара");
            }
        }
    }
    class CartItem
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public int Count { get; set; }
        public decimal Price { get; }
        public decimal Sum
        {
            get
            {
                return Count * Price;
            }
            //set
            //{
            //    Sum = Price * Count;
            //}
        }

        public CartItem(int id, Book book, int count, decimal price)
        {
            Id = id;
            Book = book;
            Count = count;
            Price = price;
        }
        public static CartItem[] AddItem(CartItem[] cartItems, Book book, int bookCount)
        {
            int i = cartItems.Length;
            int itemId;

            itemId = cartItems.Length + 1;     //Получили индекс
            Array.Resize(ref cartItems, cartItems.Length + 1);
            //Console.WriteLine("Добавли размерность + 1: " + cartItems.Length);
            //Получаем книгу

            //item init
            cartItems[i] = new CartItem(itemId, book, bookCount, book.Price);
            //Console.WriteLine(cartItems.GetType());
            //Console.WriteLine(book.GetType());
            //cartItems[i].ItemBook = book;
            //Console.WriteLine("После добавления размер массива заказов: " + cartItems.Length);
            //Console.WriteLine(cartItems[i].ItemBook.Title);
            //кол-во экземпляров
            //cartItems[i].ItemCount = itemCount;
            Console.WriteLine("{0} {1}шт. добавлено!", cartItems[i].Book.Title, cartItems[i].Count);
            return cartItems;
        }
    }
}