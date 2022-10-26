using System;
using System.Collections.Generic;
using System.Linq;

namespace module14
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Обезьяна", "Лягушка", "Кот", "Собака", "Черепаха" };
            // проекция в анонимный тип
            var sWords = words.Select(w => new
            {
                Name = w,
                Length = w.Length
            })
            .OrderBy(word => word.Length);
            // выводим
            foreach (var word in sWords)
                Console.WriteLine($"{word.Name} - {word.Length} букв");
        }
    }
}