using System;
using System.Collections.Generic;
using System.Linq;

namespace Pair_with_a_given_sum
{
  internal class Program
  {
    private static void Main()
    {
      int[] arr = {8, 3, 1, 2};
      var mx = new MaxSum();
      var li = arr.Select((t, i) => mx.MxSum1(arr, i)).ToList();

      var p = li.Max();
      Console.WriteLine(p);
    }
  }

  internal class MaxSum
  {
    public int MxSum1(int[] arr, int n)
    {
      var list = new List<int>();
      for (var i = n; i < arr.Length; i++)
      {
        list.Add(arr[i]);
      }

      for (var i = 0; i < n; i++)
      {
        list.Add(arr[i]);
      }

      var sum = 0;
      for (var i = 0; i < arr.Length; i++)
      {
        sum += (list[i] * i);
      }
      return sum;
    }
  }
}
