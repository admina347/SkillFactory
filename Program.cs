using System;
using SkillFactory.Data.Models;
using Store.Models;
using Store.DB;
/*Итоговое задание 7.7

За выполнение критериев каждого уровня вы получаете 1 балл. Вы можете выполнить только базовый уровень и получить 1 балл, 
либо выполнить базовый + продвинутый уровень за 2 балла. Если вы сможете выполнить все уровни, то получите 3 балла, 
а мы поймем, что вы поняли тему на отлично.

Базовый уровень:
+ Использование наследования;
+ Использование абстрактных классов или членов класса;
Использование принципов инкапсуляции;
Использование переопределений методов/свойств;
+ Использование минимум 4 собственных классов;
+ Использование конструкторов классов с параметрами;
Использование обобщений;
Использование свойств;
Использование композиции классов.

Продвинутый уровень:
Использование статических элементов или классов;
Использование обобщенных методов;
Корректное использование абстрактных классов (использовать их там, где это обусловлено параметрами системы);
Корректное использование модификаторов элементов класса (чтобы важные поля не были доступны для полного контроля извне, использование protected);
Использование свойств с логикой в get и/или set блоках.

Усложненный уровень:
Использование методов расширения;
Использование наследования обобщений;
Использование агрегации классов;
Использование индексаторов;
Использование перегруженных операторов.
*/

//Бриф
/* 
+Каталог
+Сделать каталог 
+несколько категорий товаров
+заполнить 3-5 товаров по каждой категории
---
Получатель
ФИО (Имя)
Телефон
Адрес доставки
дата, время доставки (фикс для Shop и PickPoint)
---
Список товаров массив
Поля товара: название, описание, артикул, кол-во, цена, сумма.
Сумма заказа
---
Доставка?
*/

namespace Store
{
    abstract class Delivery
    {
        public string Address;
        public string Phone;
    }
    //Доставка до двери
    class HomeDelivery : Delivery
    {
        /* доставка на дом. Этот тип будет подразумевать наличие курьера или передачу курьерской компании, в нем будет располагаться своя, отдельная от прочих типов доставки логика. */
    }

    class PickPointDelivery : Delivery
    {
        /* доставка в пункт выдачи. Здесь будет храниться какая-то ещё логика, необходимая для процесса доставки в пункт выдачи, например,
        хранение компании и точки выдачи, а также какой-то ещё информации. */
    }

    class ShopDelivery : Delivery
    {
        /* доставка в розничный магазин. Эта доставка может выполняться внутренними средствами компании и совсем не требует работы с «внешними&raquo; элементами. */
    }
    //Заказ
    class Order<TDelivery> where TDelivery : Delivery
    {
        public int Id { get; set; }
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в Первый консольный магазин книг!");
            Console.WriteLine("или не первый.");
            Console.WriteLine("-----");
            Console.WriteLine("У нас есть:");
            //
            IBookRepository bookRepository;
            bookRepository = new BookRepository();
            Book[] books = bookRepository.GetAll();
            //
            IBookGenreRepository genreRepository;
            genreRepository = new BookGenreRepository();
            BookGenreModel[] genres = genreRepository.GetAll();
            //
            //Order<Delivery> order = new Order<HomeDelivery>();
            //OrderItem[] cartItems = new OrderItem[1];
            Book book;
            book = bookRepository.GetById(1);
            //Book[] books = new[]

            //Создаем массив эолементов закза
            CartItem[] cartItems = new CartItem[0];
            //Корзина
            Cart cart = new Cart(cartItems);
            //Show Preview
            Book.ShowBooksPreview(books, 4);
        //Показать главное меню
        //case
        MainMenu:
            Menu.ShowMainMenu();
            var inputStr = Console.ReadLine();
            int bookNumber;
            bool isnumber;
            int bookCount;

        Menu:

            //Введено число (id книги)
            if (int.TryParse(inputStr, out bookNumber))
            {
                Console.WriteLine("Вывести книгу: " + inputStr);
                book = bookRepository.GetById(bookNumber);
                //Порлучить жанр
                BookGenreModel genre = genreRepository.GetById(book.GenreId);
                //Вывести инфо о книге
                Book.ShowBook(book, genre.Name);
                Menu.ShowBookMenu();
                inputStr = Console.ReadLine();
            }
            //else
            //{
            //action menu
            switch (inputStr)
            {
                case "all":
                    Console.WriteLine("Все книги:");
                    Book.ShowBooksAll(books);
                    goto MainMenu;
                //break;
                case "+":
                    Console.WriteLine("Всего книг: " + books.Length);
                    //Номер книги; 
                    do
                    {
                        Console.WriteLine("Введите № книги цифрами:");
                        inputStr = Console.ReadLine();
                    } while (CheckNum(inputStr, out bookNumber, books.Length));
                    //Добавить книгу к заказу.

                    //Количество экземпляров
                    do
                    {
                        Console.WriteLine("Введите количество экземпляров цифрами:");
                        inputStr = Console.ReadLine();
                    } while (CheckNum(inputStr, out bookCount, 10));
                    //Проверка размерности массива
                    //Console.WriteLine("Начальный размер массива заказов: " + cartItems.Length);

                    book = bookRepository.GetById(bookNumber);
                    cartItems = CartItem.AddItem(cartItems, book, bookCount);
                    Cart.CartItems = cartItems;
                    Menu.ShowCartMenu();
                    inputStr = Console.ReadLine();
                    goto Menu;
                case "cart":
                    Cart.ShowCart(cart);
                    Menu.ShowCartMenu();
                    inputStr = Console.ReadLine();
                    goto Menu;
                case "-":
                    Cart.ShowCart(cart);
                    Menu.ShowCartMenu();
                    inputStr = Console.ReadLine();
                    goto Menu;
                case "#":
                    goto MainMenu;
                case "q":
                    Console.WriteLine("Выход");
                    break;
                default:
                    Console.WriteLine("Неизвестная команда");
                    goto MainMenu;
            }
        }

        //Проверка ввода

        //Проверка числа
        static bool CheckNum(string number, out int cornumber, int booksCount)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0 && intnum < booksCount)
                {
                    cornumber = intnum;
                    return false;
                }
            }
            {
                cornumber = 0;
                return true;
            }
        }
        //Проверка строки (исключить цифры)
        static bool ChekStr(string s)
        {
            foreach (var item in s)
            {
                if (char.IsDigit(item))
                    return true; //если хоть один символ число, то выкидываешь true
            }
            return false; //если ни разу не выбило в цикле, значит, все символы - это буквы
        }

        //Создать массив любимых цветов
        static string[] CreateArrayColors(int ColorCount)
        {
            var result = new string[ColorCount];
            string istr;   //Введенные данные
            for (int i = 0; i < result.Length; i++)
            {
                do
                {
                    Console.WriteLine("Введите любимый цвет номер {0} на английском с маленькой буквы", i + 1);
                    istr = Console.ReadLine();
                } while (ChekStr(istr));
                result[i] = istr;
            }
            return result;
        }

    }
}