using System;

namespace ConsoleApp135
{
  class Program
  {
    static void Main(string[] args)
    {
      var n = 9;
      var a = 0;
      for (var i = 1; i <=n; i++)
      {
        if (n%i == 0)
        {
          a++;
        }
      }

      Console.WriteLine(a == 2 ? "{0} is prime number" : "{0} is not prime number", n);
    }
  }
}
