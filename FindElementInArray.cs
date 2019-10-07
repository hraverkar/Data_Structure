using System;

namespace ConsoleApp124
{
  internal static class Program
  {
    static void Main()
    {
      int[] arr = {2, 34, 56, 8, 98};
      var t = arr[0];
      for (var i = 0; i < arr.Length; i++)
      {
        if (t < arr[i])
        {
          t = arr[i];
        }
        
      }
      Console.WriteLine(t);
    }
  }
}
