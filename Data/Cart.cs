using System.Linq;
namespace Store.Models
{
    public class Cart
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
            if (CartItems.Length > 0 && CartItems != null)
            {
                foreach (var item in CartItems)
                {
                    Console.WriteLine("Товар {0}: {1} кол-во: {2}, Цена: {3}р. Сумма: {4}р.", item.Id, item.Book.Title, item.Count, item.Price, item.Sum);
                }
                //Total
                Console.WriteLine("Всего позиций: {0}, кол-во товара: {1}, Итого: {2}р.", CartItems.Count(), cart.TotalCount, cart.TotalPrice);
            }
            else
            {
                Console.WriteLine("Нет товара");
            }
        }
        public static void ShowOrderItems(Cart cart)
        {
            //вывесли позиции заказа (корзины)
            Console.WriteLine("Ваш заказ:");
            if (CartItems.Length > 0 && CartItems != null)
            {
                foreach (var item in CartItems)
                {
                    Console.WriteLine("Товар {0}: {1} кол-во: {2}, Цена: {3}р. Сумма: {4}р.", item.Id, item.Book.Title, item.Count, item.Price, item.Sum);
                }
                //Total
                Console.WriteLine("Всего позиций: {0}, кол-во товара: {1}, Итого: {2}р.", CartItems.Count(), cart.TotalCount, cart.TotalPrice);
            }
            else
            {
                Console.WriteLine("Нет товара");
            }
        }
    }
    public class CartItem
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
            int bookItemId = -1;    //книга есть в корзине
            //проверить есть ли книга в корзине
            if(cartItems.Count() > 0 && cartItems != null)
            {
                bookItemId = BookIdIndexOf(ref cartItems, book.Id);
                Console.WriteLine("Id книги в корзине : {0}", bookItemId);
            }

            //var res = Array.Find(cartItems, book => itemId);
            //item exist
            if(bookItemId >= 0)
            {
                cartItems[bookItemId].Count = cartItems[bookItemId].Count + bookCount;
            }
            else    //item init
            {
                itemId = cartItems.Length + 1;     //Получили индекс
                Array.Resize(ref cartItems, cartItems.Length + 1);
                cartItems[i] = new CartItem(itemId, book, bookCount, book.Price);           
                Console.WriteLine("{0} {1}шт. добавлено!", cartItems[i].Book.Title, cartItems[i].Count);
            }            
            return cartItems;
        }
        private static int CartItemIndexOf(CartItem[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Id == value) {return i;}
            }
            return -1;
        }
        //Remove item
        public static void RemoveItem(CartItem[] cartItems, int cartItemId)
        {
            //cartItemId = cartItemId - 1;
            int cartItemIndex;
            //cartItemIndex = Array.IndexOf(cartItems,cartItemId);
            //Array.Sort()
            cartItemIndex = CartItemIndexOf(cartItems, cartItemId);
            if (cartItemIndex < 0)
            return;
            Console.WriteLine("Индекс: {0}",cartItemIndex);
            CartItem[] newCartItems = new CartItem[cartItems.Length -1];
            for (int i = 0; i < cartItemIndex; i++)
                newCartItems[i] = cartItems[i];
            for (int i = cartItemIndex + 1; i < cartItems.Length; i++)
                newCartItems[i - 1] = cartItems[i];
            //Сортировка ид
            UpdateCartItemsId(newCartItems);
            Cart.CartItems = newCartItems;
        }
        private static void UpdateCartItemsId(CartItem[] cartItems)
        {
            for (int i = 0; i < cartItems.Length; i++)
            {
                cartItems[i].Id = i + 1;
            }
        }
        static int BookIdIndexOf(ref CartItem[] array, int id)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i].Book.Id == id) {return i;}
            }
            return -1;
        }
        /* public static void CartClear(CartItem[] cartItems)
        {
            Array.Clear(cartItems);
        } */
    }
}