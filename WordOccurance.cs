using System;
using System.Collections.Generic;

namespace NonRepeated
{
  internal static class Program
  {
    public static void Main(string[] args)
    {
      const string str = "geeksforgeeks";
      var test = new Test();
      var t =test.FirstNonRepeating(str);
      Console.WriteLine(t);
      Console.WriteLine(t == -1 ? "Either " +
                                      "all characters are repeating or string " +
                                      "is empty" : "First non-repeating character"
                                                   + " is " + str[t]);
    }
  }

  internal class Test
  {
    private const int No_Of_Char = 256;
    private static readonly char [] Count = new char[No_Of_Char];
  public int FirstNonRepeating(string str)
    {
      GetCharCount(str);
      var index = -1;
      for (var i = 0; i < str.Length; i++)
      {
        if (Count[str[i]] != 1) continue;
        index = i;
        break;
      }
      return index;
    }

    private static void GetCharCount(string str)
    {
      foreach (var t in str)
      {
        Count[t]++;
      }
    }
  }
}
