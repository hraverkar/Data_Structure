using System;
using System.Collections.Generic;

/* Merge Sort - 
 *  The merge sort algorithm is a divide and conquers algorithm. In the divide
 *  and conquer paradigm, a problem is broken into smaller problems where each
 *  small problem still retains all the properties of the larger problem -- except
 *  its size. To solve the original problem, each piece is solved individually;
 *  then the pieces are merged back together. 
 */


namespace MergeSort
{
  internal static class Program
  {
    private static void Main()
    {
      int[] arr = { 87, 57, 370, 110, 90, 610, 02, 710, 140, 203, 150 };
      MergeSort(arr);
    }

    private static void MergeSort(IList<int> arr)
    {
      var p = Sort(arr,0,arr.Count-1);
      foreach (var variable in p)
      {
        Console.WriteLine(variable);
      }
    }

    private static IList<int> Sort(IList<int> arr, int start, int end)
    {
      var mid = (start + end) / 2;
      if (start < end)
      {
        Sort(arr,start,mid);
        Sort(arr,mid+1,end);
      }

      int i = 0, first = start, last = mid + 1;
      // ReSharper disable once ComplexConditionExpression
      var tmp = new int[end - start +1];

      // ReSharper disable once ComplexConditionExpression
      while (first <= mid && last <=end)
      {
        tmp[i++] = arr[first] < arr[last] ? arr[first++] : arr[last++];
      }

      while (first <=mid)
      {
        tmp[i++] = arr[first++];
      }

      while (last <= end)
      {
        tmp[i++] = arr[last++];
      }

      i = 0;
      while (start <=end)
      {
        arr[start++] = tmp[i++];
      }

      return arr;
    }
  }
}
