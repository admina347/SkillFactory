using System;
using System.Collections.Generic;
using System.Linq;

namespace module14;

class Program
{
    static void Main(string[] args)
    {
        var contacts = new List<Contact>()
            {
                new Contact() { Name = "Андрей", Phone = 7999945005 },
                new Contact() { Name = "Сергей", Phone = 799990455 },
                new Contact() { Name = "Иван", Phone = 79999675 },
                new Contact() { Name = "Игорь", Phone = 8884994 },
                new Contact() { Name = "Анна", Phone = 665565656 },
                new Contact() { Name = "Василий", Phone = 3434 }
            };
        // бесконечный цикл, ожидающий ввод с консоли
        while (true)
        {
            var keyChar = Console.ReadKey().KeyChar; // получаем символ с консоли
            Console.Clear();  //  очистка консоли от введенного текста

            //  ВАШ КОД ЗДЕСЬ
            if (!Char.IsDigit(keyChar))
            {
                Console.WriteLine("Ошибка ввода, введите число");
            }
            else
            {
                //  переменная для хранения запроса в зависимости от введенного с консоли числа
                IEnumerable<Contact> page = null;

                //  выбираем нужное кол-во элементов для создания постраничного ввода в зависимости от запроса
                switch (keyChar)
                {
                    case ('1'):
                        page = contacts.Take(2);
                        break;
                    case ('2'):
                        page = contacts.Skip(2).Take(2);
                        break;
                    case ('3'):
                        page = contacts.Skip(4).Take(2);
                        break;
                }

                //   проверим, что ввели существующий номер страницы
                if (page == null)
                {
                    Console.WriteLine($"Ошибка ввода, страницы {keyChar} не существует");
                    continue;
                }

                // вывод результата на консоль
                foreach (var contact in page)
                    Console.WriteLine(contact.Name + " " + contact.Phone);
            }
        }
    }
}

internal class Contact
{
    public Contact()
    {
    }

    public string Name { get; set; }
    public long Phone { get; set; }
}