using System;
using SkillFactory.Data.Models;
using Store.Models;
using Store.Memory;
/*Итоговое задание 7.7

За выполнение критериев каждого уровня вы получаете 1 балл. Вы можете выполнить только базовый уровень и получить 1 балл, 
либо выполнить базовый + продвинутый уровень за 2 балла. Если вы сможете выполнить все уровни, то получите 3 балла, 
а мы поймем, что вы поняли тему на отлично.

Базовый уровень:
+ Использование наследования;
+ Использование абстрактных классов или членов класса;
+ Использование принципов инкапсуляции;
Использование переопределений методов/свойств;
+ Использование минимум 4 собственных классов;
+ Использование конструкторов классов с параметрами;
+ Использование обобщений;
+ Использование свойств;
Использование композиции классов.

Продвинутый уровень:
+ Использование статических элементов или классов;
+ Использование обобщенных методов;
+ Корректное использование абстрактных классов (использовать их там, где это обусловлено параметрами системы);
Корректное использование модификаторов элементов класса (чтобы важные поля не были доступны для полного контроля извне, использование protected);
+ Использование свойств с логикой в get и/или set блоках.

Усложненный уровень:
Использование методов расширения;
+ Использование наследования обобщений;
Использование агрегации классов;
+ Использование индексаторов; ?
Использование перегруженных операторов.

+ Перегруженных методов
*/

/* 
Так как не мог просто написать классы, потому что написать мог, а будет работать или нет, 
правильно или нет - пришлось реализовывать и методы все ещё чтобы проверить.
Все понукты наверное не получилось реализовать, переопределение методов, пока не пончтно где и зачем.
Индексаторы, композиции и т.д методы расширения пытался что-то но не получилось.
В данном базовом коде непонятно зачем типы доставок по классам разделены и наследуются, нужно делать отдельныее методы,
я бы наверное сделал как-то подругому, но пока мало знаний.

P.S. Можно  было еще код оптимизировать, в методы упаковать, но нет времни уже итак с опозданием сдаю.
*/

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {            
            IBookRepository bookRepository;
            bookRepository = new BookRepository();
            Book[] books = bookRepository.GetAll();
            //
            IBookGenreRepository genreRepository;
            genreRepository = new BookGenreRepository();
            BookGenreModel[] genres = genreRepository.GetAll();
            //
            Book book;
            //Создаем массив эолементов закза
            CartItem[] cartItems = new CartItem[0];
            //Корзина
            Cart cart = new Cart(cartItems);
            //Приветствие
            Menu.ShowWelcome();
            //Show Preview
            Book.ShowBooksPreview(books, 4);
            string inputStr;        //user input
            int bookNumber;
            int bookCount;
            //Показать главное меню
        MainMenu:
            Menu.ShowMainMenu();
        Menu:
            inputStr = Console.ReadLine();
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
                //inputStr = Console.ReadLine();
            }
            //action menu
            switch (inputStr)
            {
                case "all":
                    Book.ShowBooksAll(books);
                    goto MainMenu;
                case "+":
                    Console.WriteLine("Всего книг: " + books.Length);
                    //Номер книги
                    do
                    {
                        Console.WriteLine("Введите № книги цифрами:");
                        inputStr = Console.ReadLine();
                    } while (Helper.CheckBookCount(inputStr, out bookNumber, books.Length + 1));
                    //Количество экземпляров
                    do
                    {
                        Console.WriteLine("Введите количество экземпляров цифрами:");
                        inputStr = Console.ReadLine();
                    } while (Helper.CheckBookCount(inputStr, out bookCount, 10));
                    //Получить книгу
                    book = bookRepository.GetById(bookNumber);
                    cartItems = CartItem.AddItem(cartItems, book, bookCount);
                    //save cart
                    Cart.CartItems = cartItems;
                    Menu.ShowBookMenu();
                    goto Menu;
                case "cart":
                    Cart.ShowCart(cart);
                    Menu.ShowCartMenu();
                    goto Menu;
                case "-":
                    Cart.ShowCart(cart);
                    //Номер товара
                    do
                    {
                        Console.WriteLine("Введите № товара цифрами:");
                        inputStr = Console.ReadLine();
                    } while (Helper.CheckBookCount(inputStr, out bookNumber, cartItems.Length + 1));
                    cartItems = Cart.CartItems;                    
                    CartItem.RemoveItem(cartItems, bookNumber);
                    //save
                    cartItems = Cart.CartItems;
                    Cart.ShowCart(cart);
                    Menu.ShowCartMenu();
                    goto Menu;
                case "c":
                    Array.Resize(ref cartItems, 0);
                    Cart.CartItems = cartItems;
                    goto MainMenu;
                case "z":
                    Helper.NewOrder(cart);
                    break;
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
    }
}