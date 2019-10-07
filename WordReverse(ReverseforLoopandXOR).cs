using System;

namespace ConsoleApp130
{
  internal static class Program
  {
    static void Main(string[] args)
    {
      string str = "HelloHarshalRaverkar";
      ReverseWord(str);
      ReverseString(str);

    }

    private static void ReverseString(string str)
    {
      var ch = str.ToCharArray();
      var p = ch.Length-1;
      for (int i = 0; i < p; i++)
      {
        ch[i] ^= ch[p];
        ch[p] ^= ch[i];
        ch[i] ^= ch[p];
        p--;
      }
      Console.WriteLine(new string(ch));
    }

    private static void ReverseWord(string str)
    {
      var ans = string.Empty;
      for (var i = str.Length-1; i >= 0; i--)
      {
        ans += str[i];
      }
      Console.WriteLine(new string(ans));
    }
  }
}
