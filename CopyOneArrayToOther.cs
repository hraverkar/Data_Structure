using System;

namespace ConsoleApp124
{
  internal static class Program
  {
    static void Main()
    {
      int[] arr = {2, 34, 56, 8, 98};
      var t = new int[arr.Length];

      for (int i = 0; i < arr.Length; i++)
      {
        t[i] = arr[i];
      }

      foreach (var variable in t)
      {
        Console.WriteLine(variable);
      }
    }
  }
}
