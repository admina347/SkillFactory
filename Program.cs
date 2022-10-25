
namespace module14
{
    class Program
    {
        static void Main(string[] args)
        {
            var objects = new List<object>()
            {
                1,
                "Сергей ",
                "Андрей ",
                300,
            };
            var names = from a in objects
                        where a is string // проверка на совместимость с типом
                        orderby a // сортировка по имени
                        select a; // выборка

            foreach (var name in names)
                Console.WriteLine(name);
        }
    }
}