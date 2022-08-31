﻿using System;
class Company
{
    public string Type;
    public string Name;
}

class Department
{
    public Company Company;
    public City City;
}

class City
{
    public string Name;
}
class Program
{

    static void Main(string[] args)
    {
        var department = GetCurrentDepartment();
        if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
        {
            Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания");
        }
    }

    static Department GetCurrentDepartment()
    {
        City city = new City { Name = "Санкт-Петербург" };
        Company company = new Company { Type = "Банк", Name = null };
        Department dep = new Department();
        dep.Company = company;
        dep.City = city;
        return dep;
    }
}
