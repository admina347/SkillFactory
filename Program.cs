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
        var result2 = employees.Join(departments, // передаем в качестве параметра вторую коллекцию
            emp => emp.DepartmentId, // указываем общее свойство для первой коллекции
            dep => dep.Id, // указываем общее свойство для второй коллекции
            (emp, dep) =>
            new // проекция в новый тип
            {
                Name = emp.Name,
                DepName = dep.Name
            });

        // Вывод:
        foreach (var em in result2)
        {
            Console.WriteLine(em.Name + ": " + em.DepName);
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