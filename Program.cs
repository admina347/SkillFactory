using System;
using System.Collections.Generic;
using System.Linq;

namespace module15;

class Program
{
    //   статическая переменная для хранения данных в памяти
    public static List<int> Numbers = new List<int>();
    static void Main(string[] args)
    {
        var departments = new List<Department>()
        {
            new Department() {Id = 1, Name = "Программирование"},
            new Department() {Id = 2, Name = "Продажи"}
        };

        var employees = new List<Employee>()
        {
            new Employee() { DepartmentId = 1, Name = "Инна", Id = 1},
            new Employee() { DepartmentId = 1, Name = "Андрей", Id = 2},
            new Employee() { DepartmentId = 2, Name = "Виктор ", Id = 3},
            new Employee() { DepartmentId = 3, Name = "Альберт ", Id = 4},
        };
        var result2 = departments.GroupJoin(employees, // передаем в качестве параметра вторую коллекцию
            dep => dep.Id, // указываем общее свойство для второй коллекции
            emp => emp.DepartmentId, // указываем общее свойство для первой коллекции
            (d, emps) =>
            new // проекция в новый тип
            {
                DepName = d.Name,
                Emps = emps.Select(d => d.Name)
            });

        // Вывод:
        foreach (var team in result2)
        {
            Console.WriteLine(team.DepName + ":");

            foreach (string em in team.Emps)
                Console.WriteLine(em);

            Console.WriteLine();
        }

    }

}

internal class Employee
{
    public Employee()
    {
    }

    public int DepartmentId { get; set; }
    public string Name { get; set; }
    public int Id { get; set; }
}

internal class Department
{
    public Department()
    {
    }

    public int Id { get; set; }
    public string Name { get; set; }
}