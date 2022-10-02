namespace Unit10
{
    public class Logger : ILogger
    {
        void ILogger.Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        void ILogger.Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
    }
}