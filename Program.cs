using System;
using System.Collections.Generic;
using System.Linq;

namespace module15;

class Program
{
    static void Main(string[] args)
    {
        /* //  Подготовим тестовые данные
        var names = new List<string>() { "Вася", "Вова", "Петя", "Андрей" };

        // Подготовим тестовую выборку (без ToArray())
        var experiment = names.Where(name => name.StartsWith("В"));

        // уберем несколько элементов уже после выборки (если она выполняется отложено, то они в неё не попадут)
        names.Remove("Вася");
        names.Remove("Вова");

        // обратимся к выборке в цикле foreach
        foreach (var word in experiment)
            Console.WriteLine(word); */

        //  Снова возьмем те же тестовые данные
        var names = new List<string>() { "Вася", "Вова", "Петя", "Андрей" };

        // Теперь добавим ToArray() в конце того же самого LINQ-запроса
        var experiment = names.Where(name => name.StartsWith("В")).ToArray();

        // Также уберем несколько элементов
        names.Remove("Вася");
        names.Remove("Вова");

        // обратимся к выборку в цикле foreach
        foreach (var word in experiment)
            Console.WriteLine(word);

    }

}