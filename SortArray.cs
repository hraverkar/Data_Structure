using System;
/* Sorting Problem : { 154,245,859,36,41,2,58,63,4,12}
 *
 */
namespace ConsoleApp137
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      int[] arr = {154, 245, 859, 36, 41, 2, 58, 63, 4, 12};
      var len = arr.Length;

      for (var i = 0; i < len; i++)
      {
        for (var j = 0; j < len; j++)
        {
          if (arr[i] < arr[j])
          {
            var temp = arr[j];
            arr[j] = arr[i];
            arr[i] = temp;
          }
        }
      }

      foreach (var variable in arr)
      {
        Console.WriteLine(variable);
      }
    }
  }
}
