namespace Store.Models
{
    public class Courier
    {
        public int Id { get; }
        public string Name { get; }
        public string Phone { get; }
        public Courier(int id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }
        public static void ShowCouriersAll(Courier[] couriers)
        {
            Console.WriteLine("Выберите службу доставки:");
            foreach (var item in couriers)
            {
                Console.WriteLine("{0}: {1} Тел.: {2}.", item.Id, item.Name, item.Phone);
            }
        }
    }
}