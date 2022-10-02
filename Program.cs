namespace Unit10
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            int a = 0, b = 0;
            string calcAction = "+";
        inp:
            try
            {
                Console.WriteLine("Введите число 1");
                a = calc.Read();
                Console.WriteLine("Введите число 2");
                b = calc.Read();
                //Console.WriteLine("Введите действие: Сложение +, Вычитание -, Умножение *, Деление /.");
                calcAction = calc.ReadAction();
                //Console.WriteLine(calcAction);
                calc.GetResult(a, b, calcAction);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено не корректное значение");
                goto inp;
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Введеное значение находится за пределами границ массива или коллекции.");
            }
        }
    }
}