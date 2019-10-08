using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp136
{
  internal static class Program
  {
    private static void Main()
    {
      var list = FindPrimeNumber();
      foreach (var variable in list)
      {
        foreach (var t in list.Where(t => variable + t == 56))
        {
          Console.WriteLine("First Number : " + t + " : Second Number: " + variable);
        }
      }
    }

    private static List<int> FindPrimeNumber()
    {
      int number;
      var list = new List<int>();
      for (number = 1; number <= 100; number++)
      {
        var count = 0;
        int i;
        for (i = 2; i < number / 2; i++)
        {
          if (number % i != 0) continue;
          count++;
          break;
        }

        if (count != 0) continue;
        if (number != 1)
        {
          list.Add(number);
        }
      }
      return list;
    }
  }
}
