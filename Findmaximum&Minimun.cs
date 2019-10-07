using System;
using System.Collections.Generic;

namespace ConsoleApp126
{
  internal static class Program
  {
    private static void Main()
    {
      int[] arr = {34, 53, 56, 1, 45, 89, 7, 6, 99, 47, 78, 8};
      FindSmallest(arr);
    }

    private static void FindSmallest(IReadOnlyList<int> arr)
    {
      var t = arr[0];
      var t1 = arr[0];

      for (var i = 0; i < arr.Count; i++)
      {
        if (t < arr[i])
        {
          t = arr[i];
        }
        else if (t1 > arr[i])
        {
          t1 = arr[i];
        }
      }

      Console.WriteLine("Maximum element in given array : " + t);
      Console.WriteLine("Minimum element in given array : " + t1);
    }
  }
}
