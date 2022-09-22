namespace Unit961 //9.6.1 (HW-03)
{
    public class MyException : Exception
    {
        public MyException() { }

        public MyException(string message) : base(message) { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[]
            {
                new ArgumentException("Непустой аргумент, передаваемый в метод, является недопустимым."),
                new DirectoryNotFoundException("Недопустимая часть пути к каталогу."),
                new DriveNotFoundException("Диск недоступен или не существует."),
                new FileNotFoundException("Файл не существует."),
                new FormatException("Значение не находится в соответствующем формате для преобразования из строки методом преобразования, например Parse."),
                new MyException("Мое исключение")
            };
            foreach (Exception e in exceptions)
            {
                try
                {
                    throw e;
                }
                catch (MyException ex)
                {
                    Console.WriteLine("{0}\n Перейдите по ссылке https://learn.microsoft.com/ru-ru/dotnet/csharp/fundamentals/exceptions/exception-handling", ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: {0}", ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                }
            }
        }
    }
}