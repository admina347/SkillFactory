using System;
/*Задание 7.6.10
Переименуйте универсальные параметры в более читаемые, например, TEngine и TPart.*/

class Car<TEngine> where TEngine : Engine
{
    public virtual void ChangePart<TPart>(TPart newPart) where TPart : CarPart {}
}
class ElectricEngine : Engine {}
class GasEngine : Engine {}
abstract class Engine {}
abstract class CarPart {}
class Battery : CarPart {}
class Differential : CarPart {}
class Wheel : CarPart {}
class Program
{
    static void Main(string[] args)
    {

    }
}