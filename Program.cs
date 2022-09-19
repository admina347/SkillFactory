/* Создайте консольное решение, в котором реализуйте конструкцию Try/Catch/Finally 
для обработки исключения RankException. 
В случае исключения отобразите в консоль тип исключения (через метод GetType()).*/
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Блок try начал работу");
            throw new RankException("Возникло исключение RankException");
        }
        catch (RankException ex)
        {
            Console.WriteLine(ex.GetType());
        }
        finally
        {
            Console.WriteLine("Блок fianly отработал");
        }
    }
}