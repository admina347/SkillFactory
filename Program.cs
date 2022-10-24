using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace PhoneBook
{
    class Program
    {
        

        static void Main(string[] args)
        {
            // Запустим таймер
            var watchTwo = Stopwatch.StartNew();

            // Выполним вставку
            List<string> list = new List<string>();
            String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("/home/admina/Документы/C-sharp курс/module13/Text1.txt");
                //Read the first line of text
                Console.WriteLine("Открыли файл");
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to list
                    list.Add(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                Console.WriteLine("Закрыли файл");
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            // Выведем результат
            Console.WriteLine($"Вставка в список: {watchTwo.Elapsed.TotalMilliseconds}  мс");
            Console.ReadLine();
        }
    }
}