namespace Unit10
{
    public interface ICalc
    {
        void GetResult(int a, int b, string action, ILogger logger);
        int Read(ILogger logger);
        string ReadAction(ILogger logger);
    }
}