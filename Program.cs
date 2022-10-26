using System;
using System.Collections.Generic;
using System.Linq;

namespace module14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Наш список студентов
            List<Student> students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }},
                new Student {Name="Василий", Age=24, Languages = new List<string> {"испанский", "немецкий" }}
            };
            var anketa = from s in students
                         where s.Age < 27 // берем тех, кто младше 27
                         let birthYear = DateTime.Now.Year - s.Age // Вычисляем год рождения
                                                                   // спроецируем в новую сущеность анкеты
                         select new Application()
                         {
                             Name = s.Name,
                             YearOfBirth = birthYear
                         };
            //  вывод
            foreach (var stud in anketa)
                Console.WriteLine(stud.Name + ", " + stud.YearOfBirth);
        }
    }

    public class Application
    {
        public string Name { get; set; }
        public int YearOfBirth { get; set; }
    }

    internal class Student
    {
        public string Name { get; internal set; }
        public int Age { get; internal set; }
        public List<string> Languages { get; internal set; }
    }
}