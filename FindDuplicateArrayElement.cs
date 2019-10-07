using System;
using System.Collections.Generic;

namespace ConsoleApp124
{
  internal static class Program
  {
    static void Main()
    {
      int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
      var dict = new Dictionary<int, int>();
      foreach (var variable in array)
      {
        if (dict.ContainsKey(variable))
        {
          dict[variable]++;
        }
        else
        {
          dict[variable] = 1;
        }
      }

      foreach (var pair in dict)
      {
        Console.WriteLine(pair.Key +" :: "+ pair.Value);
      }
    }
  }
}
