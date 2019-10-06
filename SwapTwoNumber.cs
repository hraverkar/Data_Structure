using System;

namespace ConsoleApp122
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 60;
      Console.WriteLine("Value of a : " + a);
      int b = 30;
      Console.WriteLine("Value of b : " + b);

      a = a + b;
      b = a - b;
      a = a - b;

      Console.WriteLine("Value of a : " + a);
      Console.WriteLine("Value of b : " + b);

    }
  }
}
