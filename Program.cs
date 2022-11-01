using System;
using System.Collections.Generic;
using System.Linq;

namespace module15;

class Program
{
    //   статическая переменная для хранения данных в памяти
    public static List<int> Numbers = new List<int>();
    static void Main(string[] args)
    {
        var phoneBook = new List<Contact>();

        // добавляем контакты
        phoneBook.Add(new Contact("Игорь", 79990000001, "igor@example.com"));
        phoneBook.Add(new Contact("Сергей", 79990000010, "serge@example.com"));
        phoneBook.Add(new Contact("Анатолий", 79990000011, "anatoly@example.com"));
        phoneBook.Add(new Contact("Валерий", 79990000012, "valera@example.com"));
        phoneBook.Add(new Contact("Сергей", 799900000013, "serg@gmail.com"));
        phoneBook.Add(new Contact("Иннокентий", 799900000013, "innokentii@example.com"));

        //  в качестве критерия группировки передаем домен адреса электронной почты
        var grouped = phoneBook.GroupBy(c => c.Email.Split("@").Last());

        // обрабатываем получившиеся группы
        foreach (var group in grouped)
        {
            // если ключ содержит example, значит, это фейк
            if (group.Key.Contains("example"))
            {
                Console.WriteLine("Фейковые адреса: ");

                foreach (var contact in group)
                    Console.WriteLine(contact.Name + " " + contact.Email);

            }
            else
            {
                Console.WriteLine("Реальные адреса: ");
                foreach (var contact in group)
                    Console.WriteLine(contact.Name + " " + contact.Email);
            }

            Console.WriteLine();
        }

    }

}

public class Contact
{
    public string Name;
    long v2;
    public string Email;

    public Contact(string Name, long v2, string Email)
    {
        this.Name = Name;
        this.v2 = v2;
        this.Email = Email;
    }
}