using System;
using System.IO;
class FileWriter
{
    public static void Main()
    {
        string filePath = @"/home/admina/Документы/VSCode/repos/SkillFactory/Program.cs"; // Укажем путь

        // Откроем файл и прочитаем его содержимое
        using (StreamReader sr = File.OpenText(filePath))
        {
            string str = "";
            while ((str = sr.ReadLine()) != null)
                Console.WriteLine(str);
        }
    }
}