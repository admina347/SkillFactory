using System;
using System.Collections.Generic;
using System.Linq;

//Есть список учеников школы с разбивкой по классам:
//Напишите метод, который соберет всех учеников всех классов в один список, используя LINQ.

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            // ???
            IEnumerable<string> names = classes.SelectMany(cl => cl.Students)
                .OrderBy(s => s);   // => new { st => st.Students};
                                                                                // проекция в анонимный тип
            // выборка имен в строки
            //var names = classes.SelectMany(c => c.Students);
            /* Console.WriteLine(names.Count());
            foreach (string stud in names)
            {
                Console.WriteLine(stud);
            } */

            //var res = array.Select((str, ind) => new { str, ind }).
            //Where(a => items.Contains(a.str)).FirstOrDefault();
            //var letters = new string[] { "A", "B", "C", "D", "E" };
            return (string[])names.ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}