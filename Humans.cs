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