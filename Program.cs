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
    /* Вернитесь к заданию 7.2.3 и дополните его код так, чтобы для вызова следующего следующего кода в консоль выводилось 2 сообщения 
    сначала "Метод класса BaseClass", а затем "Метод класса DerivedClass"): */
    class DerivedClass : BaseClass
    {

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }        
    }
    static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            
            obj.Display();
        }
}