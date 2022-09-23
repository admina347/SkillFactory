namespace EventPrictices //9.6.1 (HW-03)
{
    public class MyException : Exception
    {
        public MyException() { }

        public MyException(string message) : base(message) { }

    }
}