namespace Unit10
{
    class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();

            writer.Write();
        }
    }

    public class Writer : IWriter
    {
        public void Write()
        {
            Console.WriteLine("Write");
        }
    }

    public interface IWriter
    {
        void Write();
    }
}