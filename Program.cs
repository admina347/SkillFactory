using System;
using System.Collections.Generic;
using System.Linq;

namespace module15;

class Program
{
    static void Main(string[] args)
    {
        var contacts = new List<Contact>()
        {
            new Contact() { Name = "Андрей", Phone = 79994500508 },
            new Contact() { Name = "Сергей", Phone = 799990455 },
            new Contact() { Name = "Иван", Phone = 79999675334 },
            new Contact() { Name = "Игорь", Phone = 8884994 },
            new Contact() { Name = "Анна", Phone = 665565656 },
            new Contact() { Name = "Василий", Phone = 3434 }
        };
        var invalidContacts =
   ( from contact in contacts // пробегаемся по контактам
       let phoneString = contact.Phone.ToString() // сохраняем в промежуточную переменную строку номера телефона
       where !phoneString.StartsWith('7') || phoneString.Length != 11 // выполняем выборку по условиям
       select contact) // добавляем объект в выборку
   .Count(); // считаем количество объектов в выборке
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