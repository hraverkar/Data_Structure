using System;

namespace ConsoleApp129
{
  internal static class Program
  {
    static void Main()
    {
      const string str = "geeksforgeek";
      WordOccurance(str);
    }

    private static void WordOccurance(string str)
    {
      while (str.Length > 0)
      {
        var count = 0;
        Console.Write(str[0] +" : ");
        for (var i = 0; i < str.Length; i++)
        {
          if (str[0] == str[i])
          {
            count++;
          }
        }
        Console.WriteLine(count);
        str = str.Replace(str[0].ToString(), string.Empty);
      }

    }
  }
}
