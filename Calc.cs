namespace Unit10
{
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
    }
}