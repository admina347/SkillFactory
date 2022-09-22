namespace CovAndContrPractices
{
    class Program
    {
        public delegate Car HandlerMethod();

        public static Car CarHandler()
        {
            return null;
        }

        public static Lexus LexusHandler()
        {
            return null;
        }

        static void Main(string[] args)
        {
            HandlerMethod handlerLexus = LexusHandler;

        }
    }

    class Car { }

    class Lexus : Car {  }
}