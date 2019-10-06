using System;
using System.Collections.Generic;

namespace ConsoleApp121
{
  internal static class Program
  {
    private static void Main()
    {
      var arr = new int[] {101, 102, 103, 104, 105};
      ReverseArray(arr);
    }

    private static void ReverseArray(IList<int> arr)
    {
      var j = arr.Count - 1;
      for (var i = 0; i < j; i++)
      {
        if (arr[i] < arr[j])
        {
          var temp = arr[i];
          arr[i] = arr[j];
          arr[j] = temp;
        }

        j--;
      }

      foreach (var variable in arr)
      {
        Console.WriteLine(variable);
      }
    }
  }
}
