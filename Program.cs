using System;
using System.Collections.Generic;
using System.Linq;

namespace module14
{
    class Program
    {

        static void Main(string[] args)
        {
            // Добавим Россию с её городами
            var russianCities = new List<City>();
            russianCities.Add(new City("Москва", 11900000));
            russianCities.Add(new City("Санкт-Петербург", 4991000));
            russianCities.Add(new City("Волгоград", 1099000));
            russianCities.Add(new City("Казань", 1169000));
            russianCities.Add(new City("Севастополь", 449138));

            var bigCities = russianCities.Where(c => c.Population > 1000000)
  .OrderByDescending(c => c.Population);
            foreach (var bigCity in bigCities)
                Console.WriteLine(bigCity.Name + " - " + bigCity.Population);

            var shortNameCities = russianCities.Where(city => city.Name.Length <= 10) // выборка городов с коротким именем
                                .OrderBy(city => city.Name.Length);  // сортировка по длине имени
            foreach (var city in shortNameCities)
                Console.WriteLine(city.Name);
        }

        // Создадим модель класс для города
        public class City
        {
            public City(string name, long population)
            {
                Name = name;
                Population = population;
            }

            public string Name { get; set; }
            public long Population { get; set; }
        }
    }
}