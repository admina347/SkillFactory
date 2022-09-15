using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Serialization
{

    // Описываем наш класс и помечаем его атрибутом для последующей сериализации   
    [Serializable]
    class Contact
    {
        public string Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        public Contact(string name, long phoneNumber, string email)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // объект для сериализации
            var contact = new Contact("Ivan", 1234567890, "test@email.ru");
            Console.WriteLine("Объект создан");

            BinaryFormatter formatter = new BinaryFormatter();
            // получаем поток, куда будем записывать сериализованный объект
            using (var fs = new FileStream("myContact.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, contact);
                Console.WriteLine("Объект сериализован");
            }
            // десериализация
            using (var fs = new FileStream("myContact.dat", FileMode.OpenOrCreate))
            {
                var newContact = (Contact)formatter.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
                Console.WriteLine($"Имя: {contact.Name} --- Телефон: {contact.PhoneNumber} Email: {contact.Email}");
            }
            Console.ReadLine();
        }
    }
}