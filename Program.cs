namespace DelegatePractices
{
    class Program
    {
        delegate void CalculateDelegate(int a, int b);
        static void Main(string[] args)
        {
            CalculateDelegate calcDelegate = CalculateOne;

            calcDelegate += CalculateTwo;

            calcDelegate.Invoke(100, 30);

            Console.Read();
        }

        static void CalculateOne(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void CalculateTwo(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}