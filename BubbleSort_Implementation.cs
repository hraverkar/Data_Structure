using System;
using System.Collections.Generic;

/*  Bubble Sort is the first sorting algorithm  It's kind of 
    weird that one of the most popular sorting algorithm is also one of the 
    worst performing sorting algorithm. Bubble sort's average case performance 
    is in O(n^2), which means as the size array grows, the time it take to sort 
    that array increases quadratic. Due to this reason, bubble sort is not used 
    in production code, instead quick sort and merge sort are preferred over it
 */
namespace BubbleSort
{
  internal static class Program
  {
    private static void Main()
    {
      int[] arr = {20, 12, 45, 19, 91, 55};
      Console.WriteLine("Unsorted Array is : ");

      foreach (var a in arr)
      {
        Console.WriteLine(a);
      }
      var t = BubbleSort(arr);
      Console.WriteLine("Sorted Array is : ");
      foreach (var variable in t)
      {
        Console.WriteLine(variable);
      }
    }

    private static Array BubbleSort(int[] numbers)
    {
      for (var i = 0; i < numbers.Length; i++)
      {
        for (var j = numbers.Length-1; j>i; j--)
        {
          if (numbers[j] < numbers[j-1])
          {
            Swap(numbers, j, j-1);
          }
        }
      }
      return numbers;
    }

    private static void Swap(IList<int> arr, int from, int to)
    {
      var temp = arr[from];
      arr[from] = arr[to];
      arr[to] = temp;
    }
  }
}
