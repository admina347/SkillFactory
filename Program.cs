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
Использование минимум 4 собственных классов;
Использование конструкторов классов с параметрами;
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
    class OrderItem
    {
        public int BookId { get; }
        public int Count { get; }
        public decimal Price { get; }
        public OrderItem(int bookId, int count, decimal price)
        {
            if (count <= 0)
            throw new ArgumentOutOfRangeException("Количество должно быть больше 0");
            BookId = bookId;
            Count = count;
            Price = price;
        }
    }

    class Order
    {
        public int Id { get; set; }
        public Book[] orderBooks { get; set; }
        public int bookCount { get; set; }
    }

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
    class Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public int Number;

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
            Book book;
            Order order = new Order();
            order.Id = 1;
            Book[] orderBooks = new Book[0];
            //Console.WriteLine("Начальный размер массива заказов: " + orderBooks.Length);
            //
            //Array.Resize(ref orderBooks, 2);
            //Console.WriteLine("Новый размер: " + orderBooks.Length);

            //Show Preview
            Book.ShowBooksPreview(books, 4);
        //ShowBooksPreview(books, 4);
        /* foreach(var item in books)
        {
           Console.WriteLine("Книга {0}: {1} Цена: {2}р.", item.Id, item.Title, item.Price); 
        } */
        /* for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Книга {0}: {1} Цена: {2}р.", books[i].Id, books[i].Title, books[i].Price);
        } */
        //Показать главное меню
        //case
        MainMenu:
            ShowMainMenu();
            var inputStr = Console.ReadLine();
            int bookNumber;
            bool isnumber;
            int itemCount;
/*             isnumber = CheckNum(inputStr, out bookNumber);
            if(isnumber = true)
            {
                Console.WriteLine("Введено корректное число");
            }
            else
            {
               Console.WriteLine("Введена строка"); 
            } */

/*             //Возраст; 
        do
        {
            Console.WriteLine("Введите корректный возраст цифрами");
            inputstr = Console.ReadLine();
        } while (CheckNum(inputstr, out inputint));
        User.Age = inputint; */

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
                ShowBookMenu();
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
                        Console.WriteLine("Всего книг: " +books.Length);
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
                        } while (CheckNum(inputStr, out itemCount, 10));
                        //Проверка размерности массива
                        /* if(orderBooks.Length == 0)
                        {

                        } */
                        
                        Console.WriteLine("Начальный размер массива заказов: " + orderBooks.Length);
                        int i = orderBooks.Length;
                        Array.Resize(ref orderBooks, orderBooks.Length + 1);
                        book = bookRepository.GetById(bookNumber);
                        orderBooks[i] = book;
                        Console.WriteLine("После добавления размер массива заказов: " + orderBooks.Length);
                        Console.WriteLine(orderBooks[i].Title);
                        order.bookCount = itemCount;
                        Console.WriteLine("Название {0} количество {1}", orderBooks[i].Title, order.bookCount);
                        ShowCartMenu();
                        inputStr = Console.ReadLine();                   
                        goto Menu;
                    case "-":
                        //вывесли позиции заказа (корзины)
                        Console.WriteLine("В корзине:");
                        foreach(var item in orderBooks)
                        {
                            Console.WriteLine("Товар {0}: {1} кол-во: {2}", item.Id, item.Title, order.bookCount); 
                        } 
                        break;
                    case "#":
                        goto MainMenu;
                    case "q":
                        Console.WriteLine("Выход");
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        goto MainMenu;
                        //break;
                }
            //}
        }
        //Главное меню
        static void ShowMainMenu()
        {
            Console.WriteLine("-----");
            Console.WriteLine("Главное меню:");
            Console.WriteLine("Посмотреть все введите all");
            Console.WriteLine("Узанть о книге подробнее введите № книги");
            Console.WriteLine("Добавить книгу в корзину (к Заказу) введите + , а затем № книги");
            Console.WriteLine("Вернуться в Главное меню #");
            Console.WriteLine("Выход - q");
        }
        //Меню книги
        static void ShowBookMenu()
        {
            Console.WriteLine("-----");
            Console.WriteLine("Добавить книгу в корзину (к Заказу) введите + ");
            Console.WriteLine("Вернуться в Главное меню #");
            Console.WriteLine("Выход - q");
        }
        //Меню корзины
        static void ShowCartMenu()
        {
            Console.WriteLine("-----");
            Console.WriteLine("Добавить книгу в корзину (к Заказу) введите + ");
            Console.WriteLine("Удалить книгу из корзины (Закза) введите - ");
            Console.WriteLine("Вернуться в Главное меню - #");
            Console.WriteLine("Выход - q");
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
        
    }
}