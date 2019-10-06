using System;
/* How to convert string to integer same as ATOI();
 *
 */
namespace ConsoleApp120
{
  internal static class Program
  {
    static void Main()
    {
      string str = "89789";
      int val = myAtoi(str);
      Console.WriteLine(val);
    }

    private static int myAtoi(string str)
    {
      int res = 0;
      for (int i = 0; i < str.Length; i++)
      {
        res = res * 10 + str[i] - '0';
      }

      return res;
    }
  }
}
