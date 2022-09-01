using System;
class BaseClass
{
    protected string Name;

    public BaseClass(string name)
    {
        Name = name;
    }
}
//Для класса DerivedClass создайте 2 конструктора: один, принимающий 2 параметра — name и description, 
//второй — принимающий 3 параметра name, description и counter.
//Используйте конструктор базового класса, чтобы сократить количество кода.
class DerivedClass : BaseClass
{
    public string Description;

    public int Counter;
    //C1
    public DerivedClass(string name, string Description) : base(name)
    {
        Description = Description;

    }
    //C2
    public DerivedClass(string name, string description, int counter) : base(name)
    {
        Description = description;
        Counter = counter;
    }
    //C2-2
    /* public DerivedClass(string name, string description, int counter) : this(name, description) 
    {
        Counter = counter;
    } */
}