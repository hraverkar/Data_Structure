using System;

namespace ConsoleApp173
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      int a = 10;
      int b = 30;
      Console.WriteLine("old value a:: " + a);
      Console.WriteLine("old value b:: " + b);

      a = a + b;
      b = a - b;
      a = a - b;

      Console.WriteLine("New value a:: " + a);
      Console.WriteLine("New value b:: " + b);
    }
  }
}
