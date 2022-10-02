namespace Unit10
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            Calc calc = new Calc();
            int a = 0, b = 0;
            string calcAction = "+";
        inp:
            try
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите число 1");
                a = calc.Read(Logger);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Введите число 2");
                b = calc.Read(Logger);
                Console.ForegroundColor = ConsoleColor.White;
                calcAction = calc.ReadAction(Logger);
                Console.ForegroundColor = ConsoleColor.White;
                calc.GetResult(a, b, calcAction, Logger);
                //end
                Console.ReadKey();  //не треуется в Linux поэтому забываю иногда.
            }
            catch (FormatException)
            {
                Logger.Error("Введено не корректное значение");
                goto inp;
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
        }
    }
}