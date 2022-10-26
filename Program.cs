using System;
using System.Collections.Generic;
using System.Linq;

namespace module14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Список студентов
            var students = new List<Student>
            {
                new Student {Name="Андрей", Age=23, Languages = new List<string> {"английский", "немецкий" }},
                new Student {Name="Сергей", Age=27, Languages = new List<string> {"английский", "французский" }},
                new Student {Name="Дмитрий", Age=29, Languages = new List<string> {"английский", "испанский" }}
            };

            // Список курсов
            var coarses = new List<Coarse>
            {
                new Coarse {Name="Язык программирования C#", StartDate = new DateTime(2020, 12, 20)},
                new Coarse {Name="Язык SQL и реляционные базы данных", StartDate = new DateTime(2020, 12, 15)},
            };
            var studentsWithCoarses = from stud in students
                                      where stud.Age < 29 // берем всех студентов младше 29
                                      where stud.Languages.Contains("английский") // ищем тех, у кого в списке языков есть английский
                                      let birthYear = DateTime.Now.Year - stud.Age // Вычисляем год рождения
                                      from coarse in coarses
                                      where coarse.Name.Contains("C#") // теперь выбираем только курс по C#
                                      select new // выборка в новую сущность
                                      {
                                          Name = stud.Name,
                                          BirthYear = birthYear,
                                          CoarseName = coarse.Name
                                      };

            // выведем результат
            foreach (var stud in studentsWithCoarses)
                Console.WriteLine($"Студент {stud.Name} ({stud.BirthYear}) добавлен курс {stud.CoarseName}");
        }
    }

    internal class Coarse
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
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