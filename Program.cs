using System;
using System.Collections.Generic;
using System.Linq;

namespace module15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(CountCommon("one", "two"));
    }
    static int CountCommon(string word1, string word2)
    {
        var amount = word1.Intersect(word2)//   ищем пересечение
 .Count(); // считаем количество
        return amount;
    }
}