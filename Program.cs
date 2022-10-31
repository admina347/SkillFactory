using System;
using System.Collections.Generic;
using System.Linq;

namespace module15;

class Program
{
    static void Main(string[] args)
    {
        static long Factorial(int number)
        {
            // Коллекция для хранения чисел
            var numbers = new List<int>();

            // Добавляем все числа от 1 до n в коллекцию
            for (int i = 1; i <= number; i++)
                numbers.Add(i);

            // Выполняем агрегацию
            return numbers.Aggregate((x, y) => x * y);
        }
    }

}