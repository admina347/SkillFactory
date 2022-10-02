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

    public interface ICalc
    {
        void GetResult(int a, int b, string action);
        int Read();
        string ReadAction();
    }

    public class Calc : ICalc
    {
        public int Read()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        public string ReadAction()
        {
            string action;
        cAct:
            Console.WriteLine("Введите действие: Сложение +, Вычитание -, Умножение *, Деление /.");
            action = Console.ReadLine();
            switch (action)
            {
                case "+":
                    action = "+";
                    break;
                case "-":
                    action = "-";
                    break;
                case "*":
                    action = "*";
                    break;
                case "/":
                    action = "/";
                    break;
                default:
                    goto cAct;
            }
            return action;
        }
        public void GetResult(int a, int b, string action)
        {
            int result;
            try
            {
                switch (action)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    case "/":
                        result = a / b;
                        break;
                    default:
                        result = 0;
                        break;
                }
                Console.WriteLine("Результат: {0}", result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //Проверка строки (исключить цифры)
        private static bool ChekStr(string s)
        {
            foreach (var item in s)
            {
                if (char.IsDigit(item))
                    return true; //если хоть один символ число, то выкидываешь true
            }
            return false; //если ни разу не выбило в цикле, значит, все символы - это буквы
        }
    }
}