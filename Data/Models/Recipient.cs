namespace Store.Models
{
    public class Recipient
    {
        public string Name
        {
            get {return Name; }
            set
            {
                //Имя
                while (Helper.ChekStr(value))
                {
                    Console.WriteLine("Введите свое Имя");
                    value = Console.ReadLine();
                }

            }
        }
        public string LastName
        {
            get { return LastName; }
            set
            {
                //Фамилия
                while (Helper.ChekStr(value))
                {
                    Console.WriteLine("Введите свою Фамилию");
                    value = Console.ReadLine();
                }
            }
        }
        public string CellPhone
        {
            get { return CellPhone; }
            set
            {
               //телефон
                while (Helper.CheckPhone(value))
                {
                    Console.WriteLine("Введите номер мобильного");
                    value = Console.ReadLine();
                } 
            }
        }
    }
}