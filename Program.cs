using System;
using System.IO;
class FileWriter
{
    public static void Main()
    {
        string filePath = @"/home/admina/Документы/VSCode/repos/SkillFactory/Program.cs"; // Укажем путь

        var fileInfo = new FileInfo(filePath); // Создаем объект класса FileInfo.
        //Открываем файл и читаем из него.
        using (StreamReader sr = fileInfo.OpenText())
        {
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
        }
        //записываем в него.
        using (StreamWriter sw = fileInfo.AppendText())
        {
            sw.WriteLine("//Последнний запуск: {0}", DateTime.Now);
        }
    }
}//Последнний запуск: 15.09.2022 13:48:38
