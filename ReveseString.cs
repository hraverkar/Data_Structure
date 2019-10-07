using System;

namespace ConsoleApp130
{
  internal static class Program
  {
    static void Main(string[] args)
    {
      string str = "HelloHarshalRaverkar";
      var t = ReverseWord(str);
      Console.WriteLine(t);

    }

    private static string ReverseWord(string str)
    {
      var ans = string.Empty;
      for (var i = str.Length-1; i >= 0; i--)
      {
        ans += str[i];
      }
      return ans.Substring(0,ans.Length-1);
    }
  }
}
