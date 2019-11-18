using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp179
{
  internal static class Program //400000000
  {
    private static void Main()
    {
      int[] arr = new int[] { 1, 2, 3, 6, 7, 8, 9, 1 };
      int sum = 2;
      var t = numberOfDistinctPairs(arr, sum);
      Console.WriteLine(t);

    }

    private static int numberOfDistinctPairs(int[] arr,  int sum)
    {
      HashSet<int> hashSet = new HashSet<int>();
      HashSet<HashSet<int>> pairSet = new HashSet<HashSet<int>>();

      for (int i = 0; i <arr.Length; i++)
      {
        if (hashSet.Contains(sum - arr[i]))
        {
          HashSet<int> pair = new HashSet<int>();
          pair.Add(arr[i]);
          pair.Add(sum - arr[i]);
          pairSet.Add(pair);
        }

        hashSet.Add(arr[i]);
      }

      return pairSet.Count;
    }
  }
}
