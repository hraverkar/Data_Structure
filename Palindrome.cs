using System;

namespace ConsoleApp173
{
  internal static class Program
  {
    private static void Main()
    {
      int[] arr = {1, 2, 3};
      PrintArray(arr, 0, 0);
    }

    private static void PrintArray(int[] arr, int start, int end)
    {
      if (end == arr.Length)
      {
        return;
      }
      else if(start > end)
      {
        PrintArray(arr,0,end+1);
      }
      else
      {
        Console.Write("[");
        for (var i = start; i < end; i++)
        {
          Console.Write(arr[i]+ ", ");
        }
        Console.WriteLine(arr[end] + "]");
        PrintArray(arr,start+1, end);
      }
      return;
    }
  }
}
