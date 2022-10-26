using System;
using System.Collections.Generic;
using System.Linq;

namespace module14;

class Program
{
    static void Main(string[] args)
    {
        // Подготовка данных
        var cars = new List<Car>()
        {
            new Car("Suzuki", "JP"),
            new Car("Toyota", "JP"),
            new Car("Opel", "DE"),
            new Car("Kamaz", "RUS"),
            new Car("Lada", "RUS"),
            new Car("Lada", "RUS"),
            new Car("Honda", "JP"),
        };
        Console.Clear();
        cars.RemoveAll(car => car.CountryCode == "JP");


        foreach (var car in cars)
            Console.WriteLine(car.Manufacturer);
    }
}
public class Car
{
   public string Manufacturer { get; set; }
   public string CountryCode { get; set; }
 
   public Car(string manufacturer, string countryCode)
   {
       Manufacturer = manufacturer;
       CountryCode = countryCode;
   }
}