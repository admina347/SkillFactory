using System;
using System.IO;

class BinaryExperiment
{
    const string SettingsFileName = "/home/admina/Загрузки/BinaryFile.bin";

    static void Main()
    {
        // Пишем
        WriteValues();
        // Считываем
        ReadValues();
    }



    static void ReadValues()
    {
        string StringValue;

        if (File.Exists(SettingsFileName))
        {
            // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
            using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
            {
                // Применяем специализированные методы Read для считывания соответствующего типа данных.
                StringValue = reader.ReadString();
            }
            Console.WriteLine("Из файла считано:");
            Console.WriteLine("Строка: " + StringValue);
        }        
    }
    static void WriteValues()
        {
            // Создаем объект BinaryWriter и указываем, куда будет направлен поток данных
            using (BinaryWriter writer = new BinaryWriter(File.Open(SettingsFileName, FileMode.Append)))
            {
                // записываем данные в разном формате
                writer.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
            }
        }
}