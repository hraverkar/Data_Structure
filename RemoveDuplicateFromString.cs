using System;

namespace ConsoleApp128
{
  internal static class Program
  {
    private static void Main()
    {
      const string str = "geeksforgeeks";
      var ch = str.ToCharArray();
      var len = ch.Length;

      var t =RemoveDuplicate(ch, len);
      Console.WriteLine(t);
    }

    private static string RemoveDuplicate(char[] ch, int len)
    {
      int i;
      var index = 0;
      for (i = 0; i < len; i++)
      {
        int j;
        for ( j = 0; j < i; j++)
        {
          if (ch[i] == ch[j])
          {
            break;
          }
        }

        if (j==i)
        {
          ch[index++] = ch[i];
        }
      }

      var ans = new char[index];
      Array.Copy(ch, ans, index);
      return string.Join("", ans);
    }
  }
}
