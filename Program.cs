/* Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally 
для обработки исключения ArgumentOutOfRangeException. 
В случае исключения отобразите в консоль сообщение об ошибке. */
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Блок try начал работу");
            throw new ArgumentOutOfRangeException();
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Возникло исключение ArgumentOutOfRangeException");
        }
        finally
        {
            Console.WriteLine("Блок fianly отработал");
        }
    }
}