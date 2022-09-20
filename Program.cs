namespace DelegatePractices
{
    class Program
    {
        delegate void ShowMessageDelegate(string _message);
        static void Main(string[] args)
        {
            ShowMessageDelegate showMessageDelegate = delegate(string _message) 
            {
                Console.WriteLine(_message);
            };
            showMessageDelegate.Invoke("Hello World!");
            Console.Read();
        }

    }
}