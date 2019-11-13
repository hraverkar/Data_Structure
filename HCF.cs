using System;

namespace ConsoleApp177
{
  class Program
  {
    static void Main(string[] args)
    {
      int a =56, b = 98;
      int t =  gcd(a, b);
      Console.WriteLine(t);
    }

    private static int gcd(in int a, in int b)
    {
      if (b == 0)
        return a;
      return gcd(b, a%b);
    }
  }
}
