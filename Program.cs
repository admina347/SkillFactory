namespace Unit10
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            ((IWorker) worker).Build();

        }
    }

    public class Worker : IWorker
    {
        void IWorker.Build()
        {
            Console.WriteLine("Build");
        }
    }

    public interface IWorker
    {
        public void Build();
    }
}