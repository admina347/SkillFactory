namespace Unit10
{
    public class Calc : ICalc
    {
        ILogger Logger { get; }
        public int Read(ILogger logger)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            logger.Event("Введено число: " + number);
            return number;
        }
        public string ReadAction(ILogger logger)
        {
            string action, actionHint = "Сложение";
        cAct:
            Console.WriteLine("Введите действие: Сложение +, Вычитание -, Умножение *, Деление /.");
            action = Console.ReadLine();
            switch (action)
            {
                case "+":
                    action = "+";
                    actionHint = "Сложение";
                    break;
                case "-":
                    action = "-";
                    actionHint = "Вычитание";
                    break;
                case "*":
                    action = "*";
                    actionHint = "Умножение";
                    break;
                case "/":
                    action = "/";
                    actionHint = "Деление";
                    break;
                default:
                    goto cAct;
            }
            logger.Event("Выбрано действие: " + actionHint);
            return action;
        }
        public void GetResult(int a, int b, string action, ILogger logger)
        {
            int result;
            try
            {
                switch (action)
                {
                    case "+":
                        result = a + b;
                        logger.Event(a + " + " + b + " = " + result);
                        break;
                    case "-":
                        result = a - b;
                        logger.Event(a + " - " + b + " = " + result);
                        break;
                    case "*":
                        result = a * b;
                        logger.Event(a + " * " + b + " = " + result);
                        break;
                    case "/":
                        result = a / b;
                        logger.Event(a + " / " + b + " = " + result);
                        break;
                    default:
                        result = 0;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Результат: {0}", result);
            }
            catch (DivideByZeroException)
            {
                logger.Error("На ноль делить нельзя!");
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
            }
        }
    }
}