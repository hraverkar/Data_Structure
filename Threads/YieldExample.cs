using System;
using System.Collections;

namespace ConsoleApp103
{
  internal static class Test
  {
    public static void Main()
    {
      foreach (var variable in Func(2,10))
      {
       Console.WriteLine(variable); 
      }
      
    }

    private static IEnumerable Func(int i, int i1)
    {
      for (int j = 0; j < i1; j++)
      {
        yield return i + 2 * j;
      }
    }
  }
  
  
}
