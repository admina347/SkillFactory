/* 
Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек.
Сортировка должна происходить при помощи события. 
Сортировка происходит при введении пользователем либо числа 1 (сортировка А-Я), либо числа 2 (сортировка Я-А).
*/
namespace EventPrictices //9.6.1 (HW-03)
{
    public class Humans : IHumans
    {
        public readonly Human[] humans = new Human[]
            {
                new Human("Петров"),
                new Human("Чернов"),
                new Human("Иванов"),
                new Human("Лындаев"),
                new Human("Сидоров")
            };
        public Human[] GetAll()
        {
            return humans;
        }
        public static void ShowAll(Human[] h)
        {
            foreach (Human human in h)
            {
                Console.WriteLine(human.LastName);
            }
        }
    }
}