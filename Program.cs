namespace Unit10
{
    class Program
    {
        static void Main(string[] args)
        {
            IMessenger<Phone> viberInPhone = new Viber<Phone>();
            IMessenger<IPhone> viberInIPhone = new Viber<IPhone>();

IMessenger<Phone> viberInIphone = new Viber<IPhone>();

            viberInPhone.DeviceInfo();
            viberInIphone.DeviceInfo();
        }
    }
    public class Viber<T> : IMessenger<T> where T : Phone,
    new()
    {
        public T DeviceInfo()
        {
            T device = new T();
            Console.WriteLine(device);
            return new T();
        }
    }
    public class Phone { }

    public class IPhone : Phone { }
    public interface IMessenger<out T>
    {
        T DeviceInfo();
    }
}