using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp179
{
  internal static class Program //400000000
  {
    private static void Main()
    {
      // ReSharper disable once ComplexConditionExpression
      var arr = new[] {-10, -5, 0, 3, 7};
      var p = FixedPoint(arr);
      Console.WriteLine(p);
    }

    private static int FixedPoint(IReadOnlyList<int> arr)
    {
      var low = 0;
      var high = arr.Count - 1;
      while (low <= high)
      {
        var mid = (low + high) / 2;
        if (arr[mid] == mid)
        {
          return mid;
        }
        else if(arr[mid] > mid)
        {
          high = mid - 1;
        }
        else
        {
          low = mid + 1;
        }
      }
      return -1;
    }
  }
}
