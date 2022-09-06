using System;
/*Задание 7.6.2
Создайте класс-обобщение Car для автомобиля. Универсальным параметром будет тип двигателя в автомобиле (электрический и бензиновый). 
Для типов двигателей также создайте классы — ElectricEngine и GasEngine.

В классе Car создайте поле Engine в качестве типа которому укажите универсальный параметр.*/

class Car<T>
{
    public T Engine;
}
class ElectricEngine
{
    
}
class GasEngine
{

}
class Program
{
    static void Main(string[] args)
    {

    }
}