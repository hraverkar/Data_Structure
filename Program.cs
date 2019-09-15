using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace RotateArray
{
  internal class Program
  {
    private static void Main()
    {
      var sw = new Stopwatch();
      sw.Start();
      int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
      var n = 3;
      RotateArray(arr,n);
      sw.Stop();
      Console.WriteLine("Time Taken :{0} ms" , sw.Elapsed.TotalMilliseconds);
    }

    private static void RotateArray(IReadOnlyList<int> arr,int n)
    {
      var list = new List<int>();
      for (var i = n; i < arr.Count; i++)
      {
        list.Add(arr[i]);
      }

      for (var i = 0; i <n; i++)
      {
        list.Add(arr[i]);
      }

      foreach (var variable in list.ToArray())
      {
        Console.WriteLine(variable);
      }
    }
  }
}
