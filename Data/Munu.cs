namespace Store
{
    //Меню
    class Menu
    {
        public static void ShowWelcome()
        {
            Console.WriteLine("Добро пожаловать в Первый консольный магазин книг!");
            Console.WriteLine("или не первый.");
            Console.WriteLine("У нас есть:");
            Console.WriteLine("-Каталог-");
        }        
        public static void ShowMainMenu()
        {
            Console.WriteLine("-Главное меню-");
            Console.WriteLine("Посмотреть все введите all");
            Console.WriteLine("Узанть о книге подробнее введите № книги");
            Console.WriteLine("Добавить книгу в корзину введите +");
            Console.WriteLine("Посомтреть товары в корзине введите - cart");
            Console.WriteLine("Выход - q");
        }
        //Меню книги
        public static void ShowBookMenu()
        {
            Console.WriteLine("-Каталог-");
            Console.WriteLine("Посмотреть все введите all");
            Console.WriteLine("Добавить книгу в корзину введите +");
            Console.WriteLine("Вернуться в Главное меню #");
            Console.WriteLine("Выход - q");
        }
        //Меню корзины
        public static void ShowCartMenu()
        {
            Console.WriteLine("-Корзина-");
            Console.WriteLine("Оформить заказ ввeдиет z");
            Console.WriteLine("Удалить книгу из корзины введите -");            
            Console.WriteLine("Вернуться в Главное меню - #");
            Console.WriteLine("Выход - q");
        }
    }
}