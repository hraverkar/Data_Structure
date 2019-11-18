using System;
using System.Linq;

namespace ConsoleApp179
{
  internal static class Program //400000000
  {
    private static void Main()
    {
      var t = countDivisorInRange(1, 2000000000, 5);
      Console.WriteLine(t);
    }

    private static int countDivisorInRange(int begin, int end, int n)
    {
      int b = end / n + 1;  // From 0 to end the integers divisible by n
      int a = begin / n + 1;  // From 0 to begin the integers divisible by n

      if (begin % n == 0)
      { // "begin" is inclusive; if divisible by n then
        --a;        //   remove 1 from "a"
      }
      return b - a;



      /*int a = 0;
      var arr = new int[n];
      for (int i = begin; i <= end; i++)
      {
        if (i % n == 0)
        {
          a++;
        }
      }

      return a;*/
    }
  }
}
