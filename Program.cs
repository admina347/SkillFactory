using System;
class Employee 
{
  public string Name;
  public int Age;
  public int Salary;
}
//Класс ProjectManager должен содержать строковое поле ProjectName, а класс Developer — строковое поле ProgrammingLanguage.
class ProjectManager : Employee
{
    public string ProjectName;
}
class Developer : Employee
{
    private string ProgrammingLanguage;
}