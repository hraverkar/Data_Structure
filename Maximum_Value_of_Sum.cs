using System;
using System.Collections.Generic;

namespace Pair_with_a_given_sum
{
  internal class Program
  {
    private static void Main()
    {
      int[] arr = { 1, 20, 2, 10 };
      var x = 2;
      var mx = new MaxSum();
      var y=mx.MxSum1(arr,x);
      Console.WriteLine(y);
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
