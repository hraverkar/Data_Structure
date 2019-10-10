using System;
/* Sorting Problem : { 154,245,859,36,41,2,58,63,4,12}
 *
 */
namespace ConsoleApp137
{
  internal static class Program
  {
    public static void Main()
    {
      for (int i = 1; i <= 50; i++)
      {
        if (i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine(i + " : fizz buzz");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine(i + " : fizz");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine(i + " : buzz");
        }
      }
    }
  }
}
