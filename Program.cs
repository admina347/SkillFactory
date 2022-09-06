using System;
/*адание 7.6.9
Установите ограничения на универсальные типы в классе Car. Такие, чтобы поле Engine могло принимать тип ElectricEngine и GasEngine, 
а параметр newPart метода ChangePart мог бы принимать только типы частей машины (Battery, Differential, Wheel).*/

class Car<T1> where T1 : Engine
{
    public virtual void ChangePart<T2>(T2 newPart) where T2 : CarPart {}
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