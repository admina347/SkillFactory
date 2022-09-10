using Store.Memory;
using Store.Models;

namespace Store
{
    class Helper
    {
        //fill order
        public static void NewOrder(Cart cart)
        {
            string iStr;
            int inputint;
            int deliveryType = 1;
            int courierNumber;
            Console.WriteLine("Новый заказ");
            Recipient recipient = new Recipient();
            //Name
            do
            {
                Console.WriteLine("Введите свое Имя");
                iStr = Console.ReadLine();
            } while (Helper.ChekStr(iStr));
            recipient.Name = iStr;
            //LastName
            do
            {
                Console.WriteLine("Введите свою Фамилию");
                iStr = Console.ReadLine();
            } while (Helper.ChekStr(iStr));
            recipient.LastName = iStr;
            //phone
            do
            {
                Console.WriteLine("Введите номер мобильного");
                iStr = Console.ReadLine();
            } while (Helper.CheckPhone(iStr));
            recipient.CellPhone = iStr;
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
            //new order after chek type
            if (deliveryType == 1)
            {
                Console.WriteLine("Выбран способ доставки: курьером по адресу");
                Order<HomeDelivery> order = new Order<HomeDelivery>();
                order.Id = 1;
                //init couriers
                ICourierRepository courierRepository;
                courierRepository = new CourierRepository();
                Courier[] couriers = courierRepository.GetAll();
                Courier.ShowCouriersAll(couriers);


                //iStr = Console.ReadLine();
                //Номер courier
                do
                {
                    Console.WriteLine("Введите № службы цифрами:");
                    iStr = Console.ReadLine();
                } while (Helper.CheckCourier(iStr, out courierNumber, couriers.Length + 1));
                Courier courier;
                courier = courierRepository.GetById(courierNumber);
                order.Delivery = new HomeDelivery();
                order.Delivery.Сourier = courier;
                Console.WriteLine("Выбрана служба: {0}", order.Delivery.Сourier.Name);
                //adres
                Console.WriteLine("Введите адрес доставки:");
                iStr = Console.ReadLine();    //без проверки не успеваю
                order.Delivery.Address = iStr;
                Console.WriteLine("Комментарий для курьера:");
                iStr = Console.ReadLine();    //без проверки не успеваю
                order.Delivery.Comment = iStr;
                //оставить у двери;
                bool toDoor;
                do
                {
                    Console.WriteLine("Оставить у двери?: y/n");
                    iStr = Console.ReadLine();
                } while (ActionAccept(iStr, out toDoor));
                order.Delivery.toDoor = toDoor;
                //даты доставки
                DateTime curDate = DateTime.Now;
                int dDate;
                DateTime[] deliveryDates = { curDate.AddDays(2), curDate.AddDays(3), curDate.AddDays(4), curDate.AddDays(5) };
                Console.WriteLine("Выберите дату доставки:");
                for (int i = 0; i < deliveryDates.Length; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.WriteLine("{0}: {1} c 10:00 до 15:00", i + 1, deliveryDates[i].ToString("dddd, dd MMMM yyyy"));
                    }
                    else
                    {
                        Console.WriteLine("{0}: {1} c 15:00 до 20:00", i + 1, deliveryDates[i].ToString("dddd, dd MMMM yyyy"));
                    }
                }
                //получить дату
                do
                {
                    Console.WriteLine("Введите номер даты:");
                    iStr = Console.ReadLine();
                } while (Helper.CheckBookCount(iStr, out dDate, deliveryDates.Length + 1));
                //Console.WriteLine("Выбрана дата: {0}", dDate);
                order.Delivery.DeliveryDate = deliveryDates[dDate - 1];
                if (dDate % 2 == 1)
                {
                    order.Delivery.DTime = "c 15:00 до 20:00";
                }
                else
                {

                    order.Delivery.DTime = "c 10:00 до 15:00";
                }
                Console.WriteLine("Выбрана дата: {0}", order.Delivery.DeliveryDate.ToString("dddd, dd MMMM yyyy"));
                //записать все в заказ
                order.Recipient = recipient;
                order.OrderCart = cart;
                //вывести инфо о заказе
                Order<HomeDelivery>.ShowOrder(order);
            }
            if (deliveryType == 2)
            {
                Console.WriteLine("Выбран способ доставки: в пункт выдачи");
                Order<PickPointDelivery> order = new Order<PickPointDelivery>();
                order.Id = 1;
                //init pickPoints
                IPickPointRepository pickPointRepository;
                pickPointRepository = new PickPointRepository();
                PickPoint[] pickPoints = pickPointRepository.GetAll();
                PickPoint.ShowPickPointsAll(pickPoints);
                //Номер пункта выдачи
                int pickPointNumber;
                do
                {
                    Console.WriteLine("Введите № пункта выдачи цифрами:");
                    iStr = Console.ReadLine();
                } while (Helper.CheckCourier(iStr, out pickPointNumber, pickPoints.Length + 1));
                PickPoint pickPoint;
                pickPoint = pickPointRepository.GetById(pickPointNumber);
                order.Delivery = new PickPointDelivery();
                order.Delivery.PickPoint = pickPoint;
                Console.WriteLine("Выбран пункт выдачи: {0}", order.Delivery.PickPoint.Name);
                //даты доставки
                DateTime curDate = DateTime.Now;
                order.Delivery.DeliveryDate = curDate.AddDays(5);
                //записать все в заказ
                order.Recipient = recipient;
                order.OrderCart = cart;
                //вывести инфо о заказе
                Order<PickPointDelivery>.ShowOrder(order);
            }
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
        //Проверка числа
        internal static bool CheckCourier(string number, out int cornumber, int courierCount)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0 && intnum < courierCount)
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
        //Подтвердить выбор
        internal static bool ActionAccept(string s, out bool orderAccept)
        {
            if (s == "y" || s == "Y")
            {
                orderAccept = true;
                return false;
            }
            if (s == "n" || s == "N")
            {
                orderAccept = false;
                return false;
            }
            orderAccept = false;
            return true;
        }
    }
}