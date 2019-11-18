using System;
using System.Linq;

namespace ConsoleApp179
{
  internal static class Program //400000000
  {
    private static void Main()
    {
      int [] arr = new int[]{ 12, 1, 2, 3, 0, 11, 4 };
      int n = arr.Length;
      int []low = new int[n];

      costructLowerArray(arr, low, n);
      printArray(low, n);
    }

    private static void costructLowerArray(int[] arr, int[] low, in int i)
    {
      for (int j = 0; j < i; j++)
      {
        low[j] = 0;
      }

      for (int j = 0; j < i; j++)
      {
        for (int k = j+1; k <i ; k++)
        {
          if (arr[k] < arr[j])
          {
            low[j]++;
          }
        }
      }
    }

    static void printArray(int[] arr, int size)
    {
      int i;
      for (i = 0; i < size; i++)
        Console.Write(arr[i] + " ");

      Console.WriteLine("");
    }
  }
}
