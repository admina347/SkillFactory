using System;

class Program
{
    class BaseClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }
    /* Задание 7.2.3
    Реализуйте в классе BaseClass виртуальный метод Display с типом void и без параметров, 
    который будет выводить сообщение "Метод класса BaseClass" в консоль, 
    а затем переопределите его в DerivedClass, чтобы он выводил сообщение "Метод класса DerivedClass". */
    class DerivedClass : BaseClass
    {

        public override void Display()
        {
            Console.WriteLine("Метод класса DerivedClass");
        }

        static void Main(string[] args)
        {
            BaseClass bc = new BaseClass();
            DerivedClass dc = new DerivedClass();

            bc.Display();
            dc.Display();
            ((BaseClass)dc).Display();
        }
    }
}