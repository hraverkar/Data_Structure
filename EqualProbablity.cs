using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp179
{
  internal static class Program //400000000
  {
    private static void Main()
    {
     var t = my_rand();
     Console.WriteLine(t);
    }

    private static int my_rand()
    {
      while (true)
      {
        int i;
        i = Foo() * 5 + Foo() - 5;
        if (i < 22)
        {
          return i % 7 + 1;
        }
      }
    }

    private static int Foo()
    {
      return 0;
    }
  }
}
