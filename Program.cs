using System;
/*Задание 7.6.7
Добавьте к схеме классов автомобиля следующие классы частей автомобиля: Battery, Differential, Wheel. 
Также добавьте в класс Car виртуальный обобщённый метод без реализации — ChangePart, 
который будет принимать один параметр — newPart универсального типа.*/

class Car<T1>
{
    public T1 Engine;
    public virtual void ChangePart<T2>(T2 newPart)  {}
}
class ElectricEngine {}
class GasEngine {}
class Battery {}
class Differential {}
class Wheel {}
class Program
{
    static void Main(string[] args)
    {

    }
}