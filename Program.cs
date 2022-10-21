using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PhoneBook
{
    class Program
    {
        //  Объявим  сортированный  словарь
        private static SortedDictionary<string, Contact> SortedPhoneBook = new SortedDictionary<String, Contact>()
        {
            ["Игорь"] = new Contact(79990000000, "igor@example.com"),
            ["Андрей"] = new Contact(79990000001, "andrew@example.com"),
        };

        static void Main(string[] args)
        {
            // Запустим таймер
            var watchTwo = Stopwatch.StartNew();

            // Выполним вставку
            SortedPhoneBook.TryAdd("Диана", new Contact(79160000002, "diana@example.com"));

            // Выведем результат
            Console.WriteLine($"Вставка в сортированный словарь: {watchTwo.Elapsed.TotalMilliseconds}  мс");
        }
    }

    public class Contact // модель класса
    {
        public Contact(long phoneNumber, String email) // метод-конструктор
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public long PhoneNumber { get; set; }
        public String Email { get; set; }
    }
}