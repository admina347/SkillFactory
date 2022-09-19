public class Program 
{
  public delegate int SubDelegate(int a, int b);
  static void Main(string[] args) 
  {
    SubDelegate subDelegate = Sub;
    int res = subDelegate.Invoke(10, 5);
    Console.WriteLine(res);
  }

  static int Sub(int a, int b) 
  {
    return a - b;
  }
}