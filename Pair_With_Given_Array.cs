using System;

namespace Pair_with_a_given_sum
{
  internal class Program
  {
    private static void Main()
    {
      int[] arr = {11, 15, 6, 8, 9, 10};
      const int x = 16;
      var test = new Test();
      test.Pair_With_Given_Array(arr, x);
    }
  }

  internal class Test
  {
    public void Pair_With_Given_Array(int[] arr, int x)
    {
      for (var i = 0; i < arr.Length; i++)
      {
        for (var j = i+1; j < arr.Length; j++)
        {
          if (arr[i] + arr[j] == x)
          {
            Console.WriteLine("True");
          }
        }
      }
    }
  }
}
