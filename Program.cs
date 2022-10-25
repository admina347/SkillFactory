using System;
using System.Collections.Generic;
using System.Linq;

namespace module14
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsList = new List<int[]>()
{
   new[] {2, 3, 7, 1},
   new[] {45, 17, 88, 0},
   new[] {23, 32, 44, -6},
};
            var orderedNums = numsList
               .SelectMany(s => s) // выбираем элементы
               .OrderBy(s => s); // сортируем

            // выводим
            foreach (var ord in orderedNums)
                Console.WriteLine(ord);
        }
    }
}