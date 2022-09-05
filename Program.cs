using System;
/*Задание 7.5.3
Создайте класс Helper и определите в нем статический метод Swap типа void, который принимает 2 переменные типа int и меняет их значения местами.*/
class Program
{
    class Helper
    {
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
    static void Main(string[] args)
    {
        int num1 = 3;
        int num2 = 58;
        Helper.Swap(ref num1, ref num2);
        /*передача num1 и num2 в метод*/
        Console.WriteLine(num1); //58
        Console.WriteLine(num2); //3
    }
}