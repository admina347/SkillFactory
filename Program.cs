using System;
using System.IO;
 
class BinaryExperiment
{
   const string SettingsFileName = "/home/admina/Загрузки/BinaryFile.bin";
 
   static void Main()
   {

       // Считываем
       ReadValues();
   }
 

 
   static void ReadValues()
   {
       float FloatValue;
       string StringValue;
       int IntValue;
       bool BooleanValue;
 
       if (File.Exists(SettingsFileName))
       {
           // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
           using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
           {
               // Применяем специализированные методы Read для считывания соответствующего типа данных.
               //FloatValue = reader.ReadSingle();
               StringValue = reader.ReadString();
               //IntValue = reader.ReadInt32();
               //BooleanValue = reader.ReadBoolean();
           }
 
           Console.WriteLine("Из файла считано:");
 
           //Console.WriteLine("Дробь: " + FloatValue);
           Console.WriteLine("Строка: " + StringValue);
           //Console.WriteLine("Целое: " + IntValue);
           //Console.WriteLine("Булево значение " + BooleanValue);
       }
       
   }
}