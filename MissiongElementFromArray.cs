using System;

namespace ConsoleApp123
{
  internal static class Program
  {
    private static void Main()
    {
      int[] arr = {1, 2, 3, 4, 6, 7, 9, 8, 10};
      var len = arr.Length;
      var t = 0;
      foreach (var t1 in arr)
      {
        t += t1;
      }
      var l = (1 + len)*len/2;
      var missingNumber = t - l;
      Console.WriteLine(missingNumber);
    }
  }
}
