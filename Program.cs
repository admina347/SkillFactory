using System;
/* Задание 7.2.7
Создайте схему классов A, B, C, D и E таким образом, чтобы B наследовался от A, С от A, D от B и E от C. А также:
Добавьте в класс A виртуальный метод Display (void тип, без параметров), который будет выводить в консоль "A".
В классе B скройте этот метод и сделайте так, чтобы в консоль выводилось "B".
Для класса C переопределите метод Display, чтобы в консоли было "C".
Для D снова скройте метод.
В классе E также скройте метод.*/
class Program
{
    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Метод класса A");
        }
    }
    
    class B : A
    {
        public new void Display()
        {
            Console.WriteLine("Метод класса B");
        }
    }
    class C : A
    {
        public override void Display()
        {
            Console.WriteLine("Метод класса C");
        }
    }
    class D : B
    {
        public new void Display()
        {
            Console.WriteLine("Метод класса D");
        }
    }
    class E : C
    {
        public new void Display()
        {
            Console.WriteLine("Метод класса E");
        }
    }
    static void Main(string[] args)
        {
            A obj = new A();
            
            obj.Display();
        }
}