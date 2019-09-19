using System;

namespace ConsoleApp103
{
  internal static class Program
  {
    private static void Main()
    {
      var a = new int[10];
      a = Func(2, 10);
      foreach (var t in a)
      {
        Console.WriteLine(t);
      }
    }

    private static int[] Func(int i, int i1)
    {
      int [] _number = new int[i1];
      for (var j = 0; j <i1; j++)
      {
        _number[j] = i + 2 * j;
      }
      return _number;
    }
  }
}
