using System;
using System.Collections.Generic;

namespace RemoveDuplicate
{
  internal static class Program
  {
    private static void Main()
    {
      int[] arr = {1, 2, 2, 3, 4, 4, 4, 5, 5};
      int len = arr.Length;
      var t =RemoveDuplicates(arr,len);
      for (int i = 0; i < t; i++)
      {
        Console.WriteLine(arr[i] + " ");
      }
    }

    private static int RemoveDuplicates(IList<int> arr, int len)
    {
      switch (len)
      {
        case 0:
          return len;
        case 1:
          return len;
      }

      var j = 0;
      for (var i = 0; i < len-1; i++)
      {
        if (arr[i] != arr[i+1])
        {
          arr[j++] = arr[i];
        }
      }

      arr[j++] = arr[len - 1];
      return j;
    }
  }
}
