namespace Store.Models
{
    public class Courier
    {
        public Courier(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        string Name { get; }
        string Phone { get; }
    }
}