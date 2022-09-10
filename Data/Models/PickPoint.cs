namespace Store
{
    public class PickPoint
    {
        public int Id { get; }
        public string Name { get; }
        public string Type { get; }
        public string WorkingTime { get; }
        public string Address { get; }
        public int StoreDay { get; }
        public PickPoint(int id, string name, string type, string workingTime, string address, int storeDay)
        {
            Id = id;
            Name = name;
            Type = type;
            WorkingTime = workingTime;
            Address = address;
            StoreDay = storeDay;
        }
        public static void ShowPickPointsAll(PickPoint[] pickPoints)
        {
            Console.WriteLine("Выберите пункт выдачи:");
            foreach (var item in pickPoints)
            {
                Console.WriteLine("{0}: {1} {2} ", item.Id, item.Name, item.Type);
                Console.WriteLine("адрес: {0}, режим работы: {1}, срок хранения: {2} дней", item.Address, item.WorkingTime, item.StoreDay);
                Console.WriteLine("-----");
            }
        }
    }
}