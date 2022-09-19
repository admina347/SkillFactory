public class Program 
{
  public delegate int SubDelegate(int a, int b);
  static void Main(string[] args) 
  {
    SubDelegate subDelegate = Sub;
    int resOne = subDelegate.Invoke(10, 5);
    int resTwo = subDelegate(10, 5);
    Console.WriteLine(resOne + " " + resTwo);
  }

  static int Sub(int a, int b) 
  {
    return a - b;
  }
}