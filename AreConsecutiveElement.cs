using System;
using System.Linq;

namespace ConsoleApp179
{
  internal static class Program
  {
    private static void Main()
    {
      var arr = new int[] { 67, 68, 69, 72, 70, 71 };
     var t = areConsecutiveElements(arr);
     Console.WriteLine(t);
    }

    private static bool areConsecutiveElements(int[] arr)
    {
      int min = arr[0], max = arr[0];
      var visitedArray = new int[arr.Length];
      min = arr.Min();
      max = arr.Max();

      if (arr.Length != max - min + 1)
      {
        return false;
      }

      for (int i = 0; i < arr.Length; i++)
      {
        if (visitedArray[arr[i]-min] == 0)
        {
          visitedArray[arr[i] - min] = arr[i];
        }
        else
        {
          return false;
        }
      }

      return true;
    }
  }
}
