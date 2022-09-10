using Store.Models;

namespace Store
{
    class Helper
    {
        //fill order
        public static void NewOrder()
        {
            string iStr;
            int inputint;
            int deliveryType = 1;
            Console.WriteLine("Новый заказ");
            Recipient recipient = new Recipient();
            Console.WriteLine("Введите свое Имя");
            recipient.Name = Console.ReadLine();
            Console.WriteLine("Введите свою Фамилию");
            recipient.LastName = Console.ReadLine();
            Console.WriteLine("Введите номер мобильного");
            recipient.CellPhone = Console.ReadLine();
        DType:    
            Console.WriteLine("Выберите способ получения:");
            Console.WriteLine("1 Доставка курьером по адресу");
            Console.WriteLine("2 Доставка в пункт выдачи");
            iStr = Console.ReadLine();
            switch (iStr)
            {
                case "1":
                    deliveryType = 1;
                    break;
                case "2":
                    deliveryType = 2;
                    break;
                default:
                    goto DType;
            }
            if (deliveryType == 1)
            {
                Console.WriteLine("Выбран способ доставки: курьером по адресу");
                
            }
            if (deliveryType == 2)
            Console.WriteLine("Выбран способ доставки: в пункт выдачи");


            //

        }
        //Проверка числа
        internal static bool CheckBookCount(string number, out int cornumber, int booksCount)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0 && intnum < booksCount)
                {
                    cornumber = intnum;
                    return false;
                }
            }
            {
                cornumber = 0;
                return true;
            }
        }
        internal static bool CheckPhone(string s)
        {
            foreach (var item in s)
            {
                if (!char.IsDigit(item))
                    return true; //если хоть один символ буква, то выкидываешь true
            }
            if (s.Length < 10 | s.Length > 11)
            {
                return true; //символо боььше или меньше
            }
            return false; //если ни разу не выбило в цикле, значит, все символы - это цифры
        }
        //Проверка строки (исключить цифры)
        public static bool ChekStr(string s)
        {
            foreach (var item in s)
            {
                if (char.IsDigit(item))
                    return true; //если хоть один символ число, то выкидываешь true
            }
            return false; //если ни разу не выбило в цикле, значит, все символы - это буквы
        }
    }
}