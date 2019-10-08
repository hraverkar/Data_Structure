using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp136
{
  internal static class Program
  {
    public static void Main()
    {
      int number, i;
      var list = new List<int>();
      for (number = 1; number <= 100; number++)
      {
        var count = 0;
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

      foreach (var variable in list)
      {
        foreach (var t in list.Where(t => variable + t == 100))
        {
          Console.WriteLine("First Number : " + t + " : Second Number: " + variable);
        }
      }
    }
  }
}
