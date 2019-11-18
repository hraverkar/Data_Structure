using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp179
{
  internal static class Program //400000000
  {
    private static void Main()
    {
      int[] arr = new int[] { 0, 0, 1, 2, 3, 1, 3, 6, 6 };
      int n = arr.Length;
      var t = DuplicateInArray(arr, n);
      foreach (var variable in t)
      {
        Console.WriteLine(variable);
      }

    }

    private static List<int> DuplicateInArray(int[] arr, in int i)
    {
      List<int> list = new List<int>();

      for (int j = 0; j < arr.Length; j++)
      {
        for (int k = j+1; k < arr.Length; k++)
        {
          if (arr[j] == arr[k])
          {
            list.Add(arr[j]); 
          }
        }
      }

      return list;
    }
  }
}
